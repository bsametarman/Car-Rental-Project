using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {            
            _iCarDal.Add(car);
            return new SuccessResult(Messages.SuccessMessage);      
        }

        public IResult Delete(Car car)
        {
            _iCarDal.Delete(car);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(), Messages.SuccessMessage); 
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.ColorId == id), Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.BrandId == id), Messages.SuccessMessage);
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice >= 0 )
            {
                _iCarDal.Update(car);
                return new SuccessResult(Messages.SuccessMessage);
            }
            else
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
            
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_iCarDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), Messages.SuccessMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_iCarDal.GetCarDetails(), Messages.SuccessMessage);
        }
    }
}
