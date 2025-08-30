using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.API.Data;
using TaskManagement.API.Models;

namespace TaskManagement.API.Controllers
{
    public class TasksController : BaseController
    {
        public TasksController(AppDbContext dbContext) : base(dbContext)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            return Ok(await dbContext.ProjectTasks.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetTaskById(int id)
        {
            if (id <= 0)
                return BadRequest(new ServerResponse()
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Некорректный Id" }                    
                });

            var task = await dbContext.ProjectTasks
                .FirstOrDefaultAsync(t => t.Id == id);

            if (task is null)
                return NotFound(new ServerResponse()
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.NotFound,
                    ErrorMessages = { "Неверный Id" }
                });

            return Ok(new ServerResponse()
            {
                StatusCode = HttpStatusCode.OK,
                Result = task
            });
        }
    }
}
