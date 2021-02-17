using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _iCustomerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _iCustomerDal = customerDal;
        }
        public IDataResult<List<Customer>> GetCustomersById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_iCustomerDal.GetAll(c => c.UserId == id), Messages.SuccessMessage);
        }        
        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length != 0)
            {
                _iCustomerDal.Add(customer);
                return new SuccessResult();
            }
            return new ErrorResult();
        }
        public IResult Delete(Customer customer)
        {
            _iCustomerDal.Delete(customer);
            return new SuccessResult();
        }
        public IResult Update(Customer customer)
        {
            if (customer.CompanyName.Length != 0)
            {
                _iCustomerDal.Update(customer);
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_iCustomerDal.GetAll(), Messages.SuccessMessage); 
        }
    }
}
