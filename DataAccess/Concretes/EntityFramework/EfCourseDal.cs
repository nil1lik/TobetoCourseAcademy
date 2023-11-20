using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseContext>, ICourseDal
    {
        public List<CourseDetail> GetCourseDetail()
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {
                var result = from co in context.Courses
                             join c in context.Categories
                             on co.CategoryId equals c.CategoryId
                             select new CourseDetail
                             {
                                 CourseId = co.CourseId,
                                 CourseName = co.CourseName,
                                 CategoryName = c.CategoryName,
                                 Description = co.Description
                             };
                return result.ToList();
            }
        }
    }
}
