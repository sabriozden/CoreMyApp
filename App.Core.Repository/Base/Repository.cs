using System;
using System.Linq;
using System.Linq.Expressions;
using App.Core.Entity;
using App.Core.Repository.DataContext;
using Microsoft.EntityFrameworkCore;

namespace App.Core.Repository.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected BaseDatabaseContext DatabaseContext { get; set; }

        protected Repository(BaseDatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public virtual IQueryable<TEntity> FindAll()
        {
            return DatabaseContext.Set<TEntity>().AsNoTracking();
        }

        public virtual IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return DatabaseContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public virtual TEntity Add(TEntity entity)
        {
            return DatabaseContext.Set<TEntity>().Add(entity).Entity;
        }

        public void Update(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Remove(entity);
        }
    }
}