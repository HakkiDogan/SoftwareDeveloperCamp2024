using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CourseController : ControllerBase
	{
		private readonly ICourseService _courseService;

		public CourseController(ICourseService courseService)
		{
			_courseService = courseService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			return Ok(_courseService.GetAll());
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			return Ok(_courseService.GetById(id));
		}

		[HttpPost("add")]
		public IActionResult Add(Course course)
		{
			_courseService.Add(course);
			return Ok();
		}

		[HttpPut("update")]
		public IActionResult Update(Course course)
		{
			_courseService.Update(course);
			return Ok();
		}

		[HttpDelete("delete")]
		public IActionResult Delete(Course course)
		{
			_courseService.Delete(course);
			return Ok();
		}
	}
}
