using Core.DataAccess;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepository<Car, CarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectContext context=new CarProjectContext())
            {
                var result = from c in context.Tb_Car
                             join b in context.Tb_Brand
                             on c.BrandId equals b.BrandId
                             join co in context.Tb_Color
                             on c.ColorId equals co.ColorId
                             select new CarDetailDto { Id = c.Id, CarName = c.CarName, ColorName = co.ColorName, BrandName = b.BrandName, DailyPrice = c.DailyPrice };

                return result.ToList();
            }
           
        }
    }
}
