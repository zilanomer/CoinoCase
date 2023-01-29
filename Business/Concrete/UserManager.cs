using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            // İş Kodları
            return _userDal.GetAll();
        }

        public IResult RegisterUser(User user)
        {
            // İş Kodları
            if (GetAll().Any(x=>x.Email==user.Email))
            {
                return new ErrorResult(Messages.UserInvalidEmail);
            }
            if (user.Name == null && user.SurName == null && user.Phone == null && user.Email == null && user.Address == null)
            {
                return new ErrorResult(Messages.UserInvalidFields);
            }
            _userDal.Add(user);
            return new SuccessResult (Messages.UserRegisterSuccess);
        }
        public IResult LoginUser(User user)
        {
            if (!GetAll().Any(u => u.Email == user.Email && u.Password == user.Password))
            {
                return new ErrorResult(Messages.UserLoginError);
            }

            return new SuccessResult(Messages.UserLoginSuccess);
        }
    }
}
