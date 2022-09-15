using BusinnessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.CarName + "/" + item.BrandName + "/" + item.ColorName + "/" + item.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customers customers1 = new Customers();
            customers1.UserId = 1;
            customers1.CompanyName = "Salih Talha";
            customerManager.Add(customers1);
            



            Console.ReadLine();
        }
    }
}
