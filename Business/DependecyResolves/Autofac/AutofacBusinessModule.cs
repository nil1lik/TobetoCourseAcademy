using Autofac;
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependecyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();
        }
    }
}
