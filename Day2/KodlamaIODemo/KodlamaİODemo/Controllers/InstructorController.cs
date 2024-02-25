using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InstructorController : ControllerBase
	{
		private readonly IInstructorService _instructorService;

		public InstructorController(IInstructorService instructorService)
		{
			_instructorService = instructorService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			return Ok(_instructorService.GetAll());
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			return Ok(_instructorService.GetById(id));
		}

		[HttpPost("add")]
		public IActionResult Add(Instructor instructor)
		{
			_instructorService.Add(instructor);
			return Ok();
		}

		[HttpPut("update")]
		public IActionResult Update(Instructor instructor)
		{
			_instructorService.Update(instructor);
			return Ok();
		}

		[HttpDelete("delete")]
		public IActionResult Delete(Instructor instructor)
		{
			_instructorService.Delete(instructor);
			return Ok();
		}
	}
}
