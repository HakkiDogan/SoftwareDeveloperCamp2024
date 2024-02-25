
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace KodlamaIODemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddSingleton<ICourseDal, EfCourseDal>();
			builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
			builder.Services.AddSingleton<IInstructorDal, EfInstructorDal>();
			builder.Services.AddSingleton<IInstructorService, InstructorManager>();
			builder.Services.AddSingleton<ICategoryService, CategoryManager>();
			builder.Services.AddSingleton<ICourseService, CourseManager>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
