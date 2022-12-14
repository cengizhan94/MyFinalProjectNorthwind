using Business.Abstrac;
using Business.BusinessAspect;
using Core.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstrac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }


        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }


        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }


        public User GetByMail(string mail)
        {
           return _userDal.Get(u => u.Email == mail);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }


        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
