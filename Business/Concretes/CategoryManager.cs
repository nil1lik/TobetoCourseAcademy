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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;
        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }
        public IResult Add(Category category)
        {
            if (category.CategoryName.Length < 2)
            {
                return new ErrorResult(Messages.CategoryNameValid);
            }
            _category.Add(category);
            return new SuccessResult(Messages.CategorySuccessAdded); 
        }

        public IResult Delete(Category category)
        {
            _category.Delete(category);
            return new SuccessResult(Messages.CategorySuccessDelete);

        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_category.GetAll(), Messages.CategorySuccessListed);
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_category.Get(c=> c.CategoryId == id), Messages.CategorySuccessListed);
        }

        public IResult Update(Category category)
        {
            _category.Update(category);
            return new SuccessResult(Messages.CategorySuccessUpdated);

        }

    }
}
