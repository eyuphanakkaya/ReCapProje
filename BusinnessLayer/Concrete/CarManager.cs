using BusinnessLayer.Abstract;
using BusinnessLayer.BusinessAspects.Autofac;
using BusinnessLayer.Constants;
using BusinnessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttinConcerns.Validation;
using Core.Utilities.Businness;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        ICarImageService _carImageService;

        public CarManager(ICarDal cardal, ICarImageService carImageService)
        {
            _carDal = cardal;
            _carImageService = carImageService;
        }
        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
           
           _carDal.Add(car);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new DataResult<List<Car>>(_carDal.GetAll(),true,"Araçlar Listelendi");
        }

        public IDataResult<Car> GetByBrandId(int id)
        {
            return new DataResult<Car>(_carDal.GetById(x => x.BrandId == id), true,"Id getirildi");
        }

        public IDataResult<List<Car>> GetByCarDetails(int max)
        {
            var result= _carDal.GetAll(x => x.Description.Length < max);
            return new DataResult<List<Car>>(result, true, "Selamlar");
        }


        public IDataResult<Car> GetByColorId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(x => x.ColorId == id), "Id getirildi");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(x=>x.Id==id));
        }

        public IDataResult<List<Car>> GetByUnitPrice(decimal max, decimal min)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.DailyPrice < min));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
          return new DataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),false,"İşlem başarıyla gerçekleşti");  
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "Güncelleme başarılı");
        }



       


    }
}
