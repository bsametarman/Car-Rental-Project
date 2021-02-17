using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _iUserDal;

        public UserManager(IUserDal userDal)
        {
            _iUserDal = userDal;
        }

        public IDataResult<List<User>> GetById(int id)
        {           
            return new SuccessDataResult<List<User>>(_iUserDal.GetAll(u => u.Id == id), Messages.SuccessMessage);    
        }
        public IDataResult<List<User>> GetAll()
        {            
            return new SuccessDataResult<List<User>>(_iUserDal.GetAll(), Messages.SuccessMessage);
        }
        public IResult Add(User user)
        {
            if (user.FirstName.Length != 0 && user.LastName.Length != 0)
            {
                _iUserDal.Add(user);
                return new SuccessResult();
            }
            return new ErrorResult();
        }
        public IResult Delete(User user)
        {
            _iUserDal.Delete(user);
            return new SuccessResult();
        }
        public IResult Update(User user)
        {
            if (user.FirstName.Length != 0 && user.LastName.Length != 0)
            {
                _iUserDal.Update(user);
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
