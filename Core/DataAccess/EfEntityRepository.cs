using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfEntityRepository<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity : class,IEntity, new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity t)
        {
            using (TContext context = new TContext())
            {
                var addedCar = context.Entry(t);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t)
        {
            using (TContext context = new TContext())
            {
                var deletedCar = context.Entry(t);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public void Update(TEntity t)
        {
            using (TContext context = new TContext())
            {
                var updateCar = context.Entry(t);
                updateCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
