using Core.DataAccess.EntitiyFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,MyCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyCarContext context = new MyCarContext())
            {
                var result = from cr in context.Cars
                             join c in context.Colors
                             on cr.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 Id = cr.Id,
                                 BrandId = cr.BrandId,
                                 ColorName = c.ColorName,
                                 Description = cr.Description,
                                 DailyPrice = cr.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
