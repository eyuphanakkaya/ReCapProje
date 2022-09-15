using BusinnessLayer.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customers customers)
        {
           _customerDal.Add(customers);
            return new SuccessResult("Müşteri eklendi");
        }

        public IResult Delete(Customers customers)
        {
            _customerDal.Delete(customers);
            return new SuccessResult("Müşteri silindi");
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll(),"Müşteriler Listelendi");
        }

        public IDataResult<Customers> GetByCustomerId(int id)
        {
           return new SuccessDataResult<Customers>(_customerDal.GetById(x => x.UserId == id),"Müşteri id si budur");
        }

        public IResult Update(Customers customers)
        {
            _customerDal.Update(customers);
            return new SuccessResult("Müşteri güncellendi");
        }
    }
}
