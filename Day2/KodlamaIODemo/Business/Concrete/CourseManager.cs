using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class CourseManager : ICourseService
	{
		private readonly ICourseDal _courseDal;
		public CourseManager(ICourseDal categoryDal)
		{
			_courseDal = categoryDal;
		}

		public void Add(Course course)
		{
			_courseDal.Add(course);
		}

		public void Delete(Course course)
		{
			_courseDal.Delete(course);
		}

		public List<Course> GetAll()
		{
			return _courseDal.GetAll();
		}

		public Course GetById(int courseId)
		{
			return _courseDal.Get(c => c.Id == courseId);
		}

		public void Update(Course course)
		{
			var result = _courseDal.GetAll(c => c.Id == course.Id);
		}
	}
}
