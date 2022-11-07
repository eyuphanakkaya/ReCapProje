using BusinnessLayer.Abstract;
using BusinnessLayer.BusinessAspects.Autofac;
using BusinnessLayer.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttinConcerns.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFrameWork;
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
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User users)
        {

            //ValidationTools.Validate(new UserValidator(), users);
            _usersDal.Add(users);
            return new SuccessResult("Kullanıcı Eklendi");
        }

        public IResult Delete(User users)
        {
            _usersDal.Delete(users);
            return new SuccessResult("Kullanıcı Silindi");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int id)
        {
          return new SuccessDataResult<User>(_usersDal.GetById(x => x.Id == id));
        }

        public IResult Update(User users)
        {
            _usersDal.Update(users);
            return new SuccessResult("Kullanıcı Güncellendi");
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _usersDal.GetClaims(user);
        }

        public void TAdd(User user)
        {
            _usersDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _usersDal.GetAll(u => u.Email == email).FirstOrDefault();
        }
    }
}
