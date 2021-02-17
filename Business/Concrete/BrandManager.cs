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
    public class BrandManager : IBrandService
    {
        IBrandDal _iBrandDal;

        public BrandManager(IBrandDal iBrandDal)
        {
            _iBrandDal = iBrandDal;
        }

        public IResult Add(Brand brand)
        {
            if ((brand.BrandName).Length > 2)
            {
                _iBrandDal.Add(brand);
                return new SuccessResult(Messages.SuccessMessage);
            }
            else
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
        }

        public IResult Delete(Brand brand)
        {
            _iBrandDal.Delete(brand);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Brand>> GetAll()
        {            
            return new SuccessDataResult<List<Brand>>(_iBrandDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_iBrandDal.Get(c => c.Id == id), Messages.SuccessMessage);
        }

        public IResult Update(Brand brand)
        {
            if ((brand.BrandName).Length > 2)
            {
                _iBrandDal.Update(brand);
                return new SuccessResult(Messages.SuccessMessage);
            }
            else
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
        }
    }
}
