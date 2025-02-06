using ClassLibrary.Core.Data;
using ClassLibrary.Core.Service;
using ClassLibrary1.Infra.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LearningManegmentSystemTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        ICourseService icourseService;
        public CourseController(ICourseService _icourseService)
        {
            icourseService = _icourseService;
        }


        [HttpGet]
        public IActionResult GetAllCourse()
        {
            var courses= icourseService.GetAllCourses();
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            icourseService.createCourse(course);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCourse(Course course)
        {
            icourseService.updateCourse(course); 
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCourse(int id)
        {
            icourseService.deleteCourse(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetAllCourseById")]
        public IActionResult GetAllCourseById(int id)
        {
          var allcourese=   icourseService.getCourseById(id);
            return Ok(allcourese);
        }


        [HttpDelete]
        public IActionResult DeleteCoursse(int id)
        {
            icourseService.deleteCourse(id);
            return Ok();
        }
    }
}
