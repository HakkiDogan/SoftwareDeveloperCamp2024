using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			return Ok(_categoryService.GetAll());
		}

		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			return Ok(_categoryService.GetById(id));
		}

		[HttpPost("add")]
		public IActionResult Add(Category category)
		{
			_categoryService.Add(category);
			return Ok();
		}

		[HttpPut("update")]
		public IActionResult Update(Category category)
		{
			_categoryService.Update(category);
			return Ok();
		}

		[HttpDelete("delete")]
		public IActionResult Delete(Category category)
		{
			_categoryService.Delete(category);
			return Ok();
		}
	}
}
