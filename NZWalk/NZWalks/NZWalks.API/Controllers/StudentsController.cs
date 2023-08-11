using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            string[] StudentName = new string[] { "Sagar", "Suman", "Chandan", "Manas" };

            return Ok(StudentName);

        }
    }
}
