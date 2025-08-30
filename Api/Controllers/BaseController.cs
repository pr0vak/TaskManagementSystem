using Microsoft.AspNetCore.Mvc;
using TaskManagement.API.Data;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly AppDbContext dbContext;

        public BaseController(AppDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }
    }
}
