using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file,CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarImageId(int id);
        IDataResult<CarImage> GetByCarId(int carId);
    }
}
