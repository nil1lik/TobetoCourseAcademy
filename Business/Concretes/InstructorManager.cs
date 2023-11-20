using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructor;
        public InstructorManager(IInstructorDal instructor)
        {
            _instructor = instructor;
        }
        public IResult Add(Instructor instructor)
        {
            if (instructor.First_Name.Length > 15 && instructor.Last_Name.Length > 15)
            {
                return new ErrorResult(Messages.InstructorNameValid);
            }
            _instructor.Add(instructor);
            return new SuccessResult(Messages.InstructorSuccessAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructor.Delete(instructor);
            return new SuccessResult(Messages.InstructorSuccessDelete);

        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructor.GetAll(), Messages.InstructorSuccessListed);
        }

        public IDataResult<Instructor> GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_instructor.Get(c => c.InstructorId == id), Messages.InstructorSuccessListed);
        }

        public IResult Update(Instructor instructor)
        {
            _instructor.Update(instructor);
            return new SuccessResult(Messages.InstructorSuccessUpdated);

        }
    }
}
