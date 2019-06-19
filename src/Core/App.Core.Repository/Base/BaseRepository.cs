using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using App.Core.Entity;
using App.Core.Repository.DataContext;
using Microsoft.EntityFrameworkCore;

namespace App.Core.Repository.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public BaseDatabaseContext DatabaseContext { get; }

        protected BaseRepository(BaseDatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DatabaseContext.Set<TEntity>().AsNoTracking();
        }

        public virtual IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> expression)
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