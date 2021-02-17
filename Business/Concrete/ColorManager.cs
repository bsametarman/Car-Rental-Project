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
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;
        
        public ColorManager(IColorDal iColorDal)
        {
            _iColorDal = iColorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ErrorMessage);
            }

            _iColorDal.Add(color);
            return new Result(true, Messages.SuccessMessage);
            
        }

        public IResult Delete(Color color)
        {
            _iColorDal.Delete(color);
            return new Result(true, Messages.SuccessMessage);            
        }

        public IDataResult<List<Color>> GetAll()
        {         
            return new SuccessDataResult<List<Color>>(_iColorDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<Color> GetById(int id)
        {            
            return new SuccessDataResult<Color>(_iColorDal.Get(c => c.Id == id), Messages.SuccessMessage);
        }

        public IResult Update(Color color)
        {
            if (color.ColorName.Length < 2)
            {
                return new ErrorResult(Messages.ErrorMessage);
            }

            _iColorDal.Update(color);
            return new SuccessResult(Messages.UploadedMessage);
        }
    }
}
