using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Abstract
{
    public interface IUserService
    {
        IResult Add(User users);
        IResult Delete(User users);
        IResult Update(User users);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int id);
        List<OperationClaim> GetClaims(User user);
        void TAdd(User user);
        User GetByMail(string email);
    }
}
