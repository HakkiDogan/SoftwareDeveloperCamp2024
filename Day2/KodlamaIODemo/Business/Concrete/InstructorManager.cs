using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
	private readonly IInstructorDal _instructorDal;
	public InstructorManager(IInstructorDal instructorDal)
	{
		_instructorDal = instructorDal;
	}

	public void Add(Instructor instructor)
	{
		_instructorDal.Add(instructor);
	}

	public void Delete(Instructor instructor)
	{
		_instructorDal.Delete(instructor);
	}

	public List<Instructor> GetAll()
	{
		return _instructorDal.GetAll();
	}

	public Instructor GetById(int instructorId)
	{
		return _instructorDal.Get(c => c.Id == instructorId);
	}

	public void Update(Instructor instructor)
	{
		var result = _instructorDal.GetAll(c => c.Id == instructor.Id);
	}
}
