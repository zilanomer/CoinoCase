using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public IResult Add(Category category)
        {

            if (category ==null)
            {
                return new ErrorResult(Messages.CategoryInvalidFields);
            }
            _categoryDal.Add(category);

            return new SuccessResult(Messages.CategoryAdded);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }
    }
}
