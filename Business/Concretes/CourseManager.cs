using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _course;
        public CourseManager(ICourseDal course)
        {
            _course = course;
        }
        public IResult Add(Course course)
        {
            _course.Add(course);
           return new SuccessResult(Messages.CourseSuccessAdded);
        }

        public IResult Delete(Course course)
        {
            _course.Delete(course);
            if (course.CourseName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.CourseNameValid);
            }
            return new SuccessResult(Messages.CourseSuccessDelete);
        }

        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll());
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_course.Get(co=>co.CourseId == id),Messages.CourseSuccessGetById);
        }

        public IDataResult<List<CourseDetail>> GetCourseDetail()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<CourseDetail>>();
            }
            return new SuccessDataResult<List<CourseDetail>>(_course.GetCourseDetail(),Messages.CourseDetailGettAll);
        }

        public IResult Update(Course course)
        {
            _course.Update(course);
            return new SuccessResult(Messages.CourseSuccessUpdated);
        }
    }
}
