using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IResult Add(Category category);
        List<Category> GetAll();
        IDataResult<Category> GetById(int categoryId);
    }
}
