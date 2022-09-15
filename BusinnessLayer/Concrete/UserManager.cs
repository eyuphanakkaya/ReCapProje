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
    public class UserManager : IUserService
    {
        IUsersDal _usersDal;

        public UserManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users users)
        {
            _usersDal.Add(users);
            return new SuccessResult("Kullanıcı Eklendi");
        }

        public IResult Delete(Users users)
        {
            _usersDal.Delete(users);
            return new SuccessResult("Kullanıcı Silindi");
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll());
        }

        public IDataResult<Users> GetByUserId(int id)
        {
          return new SuccessDataResult<Users>(_usersDal.GetById(x => x.Id == id));
        }

        public IResult Update(Users users)
        {
            _usersDal.Update(users);
            return new SuccessResult("Kullanıcı Güncellendi");
        }
    }
}
