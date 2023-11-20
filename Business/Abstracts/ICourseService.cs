using Core.Utilities.Result;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);

        IDataResult<List<Course>> GetAll();
        IDataResult<List<CourseDetail>> GetCourseDetail();
        IDataResult<Course> GetById(int id);

    }
}
