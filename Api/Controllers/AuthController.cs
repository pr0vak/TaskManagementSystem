using System.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.API.Data;
using TaskManagement.API.ModelDto;
using TaskManagement.API.Models;
using TaskManagement.API.Services;

namespace TaskManagement.API.Controllers;

public class AuthController : BaseController
{
    private readonly UserManager<AppUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly JwtTokenGenerator jwtTokenGenerator;

    public AuthController(AppDbContext dbContext,
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager,
        JwtTokenGenerator jwtTokenGenerator)
        : base(dbContext)
    {
        this.userManager = userManager;
        this.roleManager = roleManager;
        this.jwtTokenGenerator = jwtTokenGenerator;
    }

    [HttpPost]
    public async Task<IActionResult> Register(
        [FromBody] UserRegisterDto userRegisterDto)
    {
        if (userRegisterDto is null)
        {
            return BadRequest(new ServerResponse()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                ErrorMessages = { "Некорректные данные" }
            });
        }

        var userFromDb = await dbContext.AppUsers
            .FirstOrDefaultAsync(u => u.NormalizedUserName.Equals(
                    userRegisterDto.UserName.ToUpper()));

        if (userFromDb is not null)
        {
            return BadRequest(new ServerResponse()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                ErrorMessages = { "Пользователь с таким именем уже существует" }
            });
        }

        var newAppUser = new AppUser
        {
            UserName = userRegisterDto.UserName,
            FirstName = userRegisterDto.UserName,
            Email = userRegisterDto.Email,
            NormalizedEmail = userRegisterDto.Email.ToUpper()
        };

        var result = await userManager
            .CreateAsync(newAppUser, userRegisterDto.Password);

        if (!result.Succeeded)
        {
            return BadRequest(new ServerResponse()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                ErrorMessages = { "Ошибка регистрации" }
            });
        }

        var newRoleAppUser = string.Empty;

        if (SharedData.Roles.Admin.Equals(userRegisterDto.Role,
            StringComparison.OrdinalIgnoreCase))
        {
            newRoleAppUser = SharedData.Roles.Admin;
        }
        else if (SharedData.Roles.Manager.Equals(userRegisterDto.Role,
            StringComparison.OrdinalIgnoreCase))
        {
            newRoleAppUser = SharedData.Roles.Manager;
        }
        else
        {
            newRoleAppUser = SharedData.Roles.User;
        }

        await userManager.AddToRoleAsync(newAppUser, newRoleAppUser);

        return Ok(new ServerResponse()
        {
            StatusCode = HttpStatusCode.Created,
            Result = "Пользователь успешно зарегистрирован"
        });
    }

    [HttpPost]
    public async Task<ActionResult<ServerResponse>> Login(
        [FromBody] LoginRequestDto loginRequestDto)
    {
        if (loginRequestDto is null ||
            string.IsNullOrWhiteSpace(loginRequestDto.Email))
        {
            return BadRequest(new ServerResponse()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                ErrorMessages = { "Некорректные данные" }
            });
        }

        var userFromDb = await dbContext.AppUsers
            .FirstOrDefaultAsync(u => u.NormalizedEmail ==
                loginRequestDto.Email.ToUpper());

        if (userFromDb is null || !await userManager
            .CheckPasswordAsync(userFromDb, loginRequestDto.Password))
        {
            return BadRequest(new ServerResponse()
            {
                IsSuccess = false,
                StatusCode = HttpStatusCode.BadRequest,
                ErrorMessages = { "Неверный логин или пароль" }
            });
        }

        var roles = await userManager.GetRolesAsync(userFromDb);
        var token = jwtTokenGenerator.GenerateJwtToken(userFromDb, roles);

        return Ok(new ServerResponse()
        {
            StatusCode = HttpStatusCode.OK,
            Result = new LoginResponseDto()
            {
                Email = userFromDb.Email,
                Token = token
            }
        });
    }
}
