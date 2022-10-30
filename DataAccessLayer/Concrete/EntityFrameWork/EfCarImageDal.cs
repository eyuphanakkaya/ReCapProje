using Core.DataAccess;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EfCarImageDal:EfEntityRepository<CarImage,CarProjectContext>,ICarImageDal
    {
    }
}
