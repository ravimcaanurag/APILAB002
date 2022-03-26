using APILAB002.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILAB002.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        public readonly courseService ser;
        public CoursesController(courseService _ser)
        {
            ser = _ser;
        }

        [HttpGet]
        public IActionResult ListCourses()
        {
            return new OkObjectResult(ser.getCourses());
            
        }
    }
}
