using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFileHelper file,CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(IFileHelper file,CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarImageId(int id);
        IDataResult<CarImage> GetByCarId(int carId);
    }
}
