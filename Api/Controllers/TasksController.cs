using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.API.Controllers
{
    public class TasksController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await Task.FromResult<string>("Test"));
        }
    }
}
