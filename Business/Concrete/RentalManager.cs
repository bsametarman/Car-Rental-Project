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
    public class RentalManager : IRentalService
    {
        IRentalDal _iRentalDal;

        public RentalManager(IRentalDal iRentalDal)
        {
            _iRentalDal = iRentalDal;
        }

        public IResult Add(Rental rental)
        {                       
            _iRentalDal.Add(rental);
            return new SuccessResult();            
        }
        public IResult Delete(Rental rental)
        {
            _iRentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_iRentalDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_iRentalDal.Get(r => r.Id == id), Messages.SuccessMessage);
        }

        public IResult Update(Rental rental)
        {
            _iRentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
