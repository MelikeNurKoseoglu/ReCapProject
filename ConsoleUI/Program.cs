using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ınMemoryCarDal

            //CarManagerTest();
            Car car1 = new Car()
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 5,
                ModelYear = 2000,
                Description = "araç 1",
                DailyPrice = 12500
            };
            Car car2 = new Car()
            {
                CarId = 2,
                BrandId = 4,
                ColorId = 9,
                ModelYear = 2010,
                Description = "araç 2",
                DailyPrice = 125000
            };
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);

            InMemoryCarDal ınMemoryCarDal = new InMemoryCarDal();
            var getallN = ınMemoryCarDal.GetAll();

            foreach (var item in getallN)
            {
                Console.WriteLine(item.CarId);
            }

        //    CarManager carManager = new CarManager(new InMemoryCarDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    foreach (var car in carManager.GetCarsByBrandId(sayi))
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    carManager.Add(car1);

        //    carManager.Update(car2);

        //    carManager.Delete(car1);

        //    Console.ReadKey();
        //}

        //private static void CarManagerTest()
        //{
        //    CarManager carManager = new CarManager(new EFCarDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + " " + car.Description);
        //    }
        }
    }
}
