using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,TobetoCourseContext> , ICategoryDal
    {
        
    }
}
