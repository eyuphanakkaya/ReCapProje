using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=1250,Description="Açıklama"},
                 new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=250,Description="Açıklam2a"},
                  new Car{Id=3,BrandId=3,ColorId=3,DailyPrice=125,Description="Açıklama3"},
                   new Car{Id=4,BrandId=4,ColorId=4,DailyPrice=120,Description="Açıklama4"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var Value = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(Value);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            var Value = _cars.SingleOrDefault(c => c.Id == Id);
            return Value;
        }

        public Car GetById(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var value = _cars.SingleOrDefault(x => x.Id == car.Id);
            value.BrandId = car.BrandId;
            value.ColorId = car.ColorId;
            value.DailyPrice = car.DailyPrice;
            value.Description = car.Description;

        }
    }
}
