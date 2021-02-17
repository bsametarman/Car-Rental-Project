using Business.Abstract;
using Business.Concrete;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            ////foreach (var car in carManager.GetCarDetails())
            ////{
            ////    //Console.WriteLine(car.Description + "--------" + car.ColorName + "-------" + car.DailyPrice);
            ////}

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //foreach (IDataResult<List<Customer>> customer in customerManager.GetAll())
            //{
            //    Console.WriteLine(new SuccessDataResult<List<Customer>>(customer.Data, Messages.SuccessMessage)); 
            //}

            



        }
    }
}
