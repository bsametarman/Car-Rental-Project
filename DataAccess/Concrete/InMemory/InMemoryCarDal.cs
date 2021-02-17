//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    //public class InMemoryCarDal : ICarDal
//    //{
//    //    List<Car> _cars = null;

//    //    public InMemoryCarDal()
//    //    {
//    //        _cars = new List<Car> {
//    //        new Car{BrandId=1,Id=1,ColorId=1,ModelYear=2010,Description="Toyota Corolla 1.6 Gasoline", DailyPrice=150 },
//    //        new Car{BrandId=2,Id=2,ColorId=2,ModelYear=2018,Description="Peugeot 2008", DailyPrice=200 },
//    //        new Car{BrandId=3,Id=3,ColorId=5,ModelYear=2020,Description="Mercedes S Class 2020", DailyPrice=650 },
//    //        new Car{BrandId=4,Id=4,ColorId=1,ModelYear=2015,Description="Volvo D4", DailyPrice=300 },
//    //        new Car{BrandId=5,Id=5,ColorId=1,ModelYear=2008,Description="Renault Clio", DailyPrice=150 },
//    //        new Car{BrandId=6,Id=6,ColorId=3,ModelYear=2008,Description="Opel Corsa 1.6", DailyPrice=150 }
//    //        };

//    //    }
//    //    public void Add(Car car)
//    //    {
//    //        _cars.Add(car);
//    //    }

//    //    public void Delete(Car car)
//    //    {
//    //        Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
//    //        _cars.Remove(carToDelete);
//    //    }

//    //    public List<Car> GetAll()
//    //    {
//    //        return _cars;
//    //    }

//    //    public List<Car> GetById(int Id)
//    //    {
//    //        return _cars.Where(c => c.Id ==Id).ToList();

//    //    }

//    //    public void Update(Car car)
//    //    {
//    //        Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
//    //        carToUpdate.BrandId = car.BrandId;
//    //        carToUpdate.ColorId = car.ColorId;
//    //        carToUpdate.DailyPrice = car.DailyPrice;
//    //        carToUpdate.Description = car.Description;
//    //        carToUpdate.ModelYear = car.ModelYear;
//    //    }
//    //}
//}
