﻿using Core.Utilities.Results;
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
        IResult Add(Users users);
        IResult Delete(Users users);
        IResult Update(Users users);
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetByUserId(int id);
    }
}
