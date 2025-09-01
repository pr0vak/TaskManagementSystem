using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.API.Data;
using TaskManagement.API.ModelDto;
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

        [HttpGet("{id}", Name = nameof(GetTaskById))]
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

        [HttpPost]
        public async Task<ActionResult<ServerResponse>> CreateTask(
            [FromBody] TaskCreateDto taskCreateDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!Enum.IsDefined(taskCreateDto.Status))
                    {
                        return BadRequest(new ServerResponse()
                        {
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest,
                            ErrorMessages = { "Некорректный статус задачи" }
                        });
                    }

                    ProjectTask task = new()
                    {
                        Title = taskCreateDto.Title,
                        Description = taskCreateDto.Description,
                        Status = taskCreateDto.Status
                    };

                    await dbContext.ProjectTasks.AddAsync(task);
                    await dbContext.SaveChangesAsync();

                    var response = new ServerResponse()
                    {
                        StatusCode = HttpStatusCode.Created,
                        Result = task
                    };

                    return CreatedAtRoute(nameof(GetTaskById), new { id = task.Id }, response);
                }
                else
                {
                    return BadRequest(new ServerResponse()
                    {
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Модель данных не валидна" }
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ServerResponse()
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessages = { "Что-то пошло не так", ex.Message }
                });
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServerResponse>> UpdateTask(
            int id, [FromBody] TaskUpdateDto taskUpdateDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (taskUpdateDto is null || taskUpdateDto.Id != id)
                    {
                        return BadRequest(new ServerResponse()
                        {
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.BadRequest,
                            ErrorMessages = { "Модель данных не валидна" }
                        });
                    }

                    var taskFromDb = await dbContext.ProjectTasks.FindAsync(id);

                    if (taskFromDb is null)
                    {
                        return NotFound(new ServerResponse()
                        {
                            IsSuccess = false,
                            StatusCode = HttpStatusCode.NotFound,
                            ErrorMessages = { "Задача не найдена" }
                        });
                    }

                    if (!string.IsNullOrWhiteSpace(taskUpdateDto.Description))
                    {
                        taskFromDb.Description = taskUpdateDto.Description;
                    }

                    taskFromDb.Title = taskUpdateDto.Title;
                    taskFromDb.Status = (Models.TaskStatus)taskUpdateDto.Status;

                    dbContext.ProjectTasks.Update(taskFromDb);
                    await dbContext.SaveChangesAsync();

                    return Ok(new ServerResponse()
                    {
                        StatusCode = HttpStatusCode.OK,
                        Result = taskFromDb
                    });
                }
                else
                {
                    return BadRequest(new ServerResponse()
                    {
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Модель данных не валидна" }
                    });
                }
            }
            catch (Exception ex)
            {
                    return BadRequest(new ServerResponse()
                    {
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.BadRequest,
                        ErrorMessages = { "Что-то пошло не так", ex.Message }
                    });
            }
        }
    }
}
