using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal(List<Car> cars)
        {
            _cars = cars;
        }
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=23,ModelYear=2000,DailyPrice=30000,Description="Araba 1"},
                new Car{CarId=2,BrandId=1,ColorId=45,ModelYear=2020,DailyPrice=200000,Description="Araba 2"},
                new Car{CarId=3,BrandId=2,ColorId=9,ModelYear=2015,DailyPrice=98000,Description="Araba 3"},
                new Car{CarId=4,BrandId=2,ColorId=3,ModelYear=2005,DailyPrice=78000,Description="Araba 4"},
                new Car{CarId=5,BrandId=2,ColorId=43,ModelYear=1980,DailyPrice=3000000,Description="Araba 5"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public Car GetT(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c1=> c1.CarId == car.CarId);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;

        }
    }
}
