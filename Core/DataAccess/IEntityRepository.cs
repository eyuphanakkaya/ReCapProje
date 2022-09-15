﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetById(Expression<Func<T,bool>> filter=null);
    }
}
