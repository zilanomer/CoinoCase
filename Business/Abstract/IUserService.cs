using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        IResult RegisterUser(User user);
        IResult LoginUser(User user);
    }
}
