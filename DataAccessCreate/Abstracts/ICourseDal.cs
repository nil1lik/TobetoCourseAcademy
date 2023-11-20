using Core.DataAccess;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal  :IEntityRepository<Course>
    {
        List<CourseDetail> GetCourseDetail();
    }
}
