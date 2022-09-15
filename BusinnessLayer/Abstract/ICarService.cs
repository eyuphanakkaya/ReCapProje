using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetById(int id);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IDataResult<Car> GetByColorId(int id);
        IDataResult<Car> GetByBrandId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal max,decimal min);
        IDataResult<List<Car>> GetByCarDetails(int max);

    }
}
