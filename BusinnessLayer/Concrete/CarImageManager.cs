using BusinnessLayer.Abstract;
using BusinnessLayer.Constants;
using Core.Utilities.Businness;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFileHelper fileHelper,CarImage carImage)
        {
            IResult result = BusinnessRules.Run(CheckCarPicturePieces(carImage.Id));

            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _fileHelper.Upload(fileHelper, PathConstants.ImagesPath);
            _carImageDal.Add(carImage);
            carImage.Date=DateTime.Now;
            return new SuccessResult("Resim eklendi");
        }

        public IResult Delete(IFileHelper file, CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult("Resim silindi");
        }

        public IDataResult<List<CarImage>> GetAll()
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), "Resimler Listelendi");
        }

        public IDataResult<CarImage> GetByCarId(int carId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(x => x.Id == carId));
        }

        public IDataResult<List<CarImage>> GetByCarImageId(int id)
        {
            var result = BusinnessRules.Run(CheckCarImage(id));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(id).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }

        public IResult Update(CarImage carImage)
        {
           _carImageDal.Update(carImage);
            return new SuccessResult("Resim güncellendi");
        }


        private IResult CheckCarPicturePieces(int carImageId)
        {
            var result = _carImageDal.GetAll();
            if (result.Count > 5)
            {
                return new ErrorResult(Messages.CarPicturePieces);
            }
            return new SuccessResult();
        }
        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {

            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }
        private IResult CheckCarImage(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
