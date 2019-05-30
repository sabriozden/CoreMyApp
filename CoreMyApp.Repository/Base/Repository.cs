using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CoreMyApp.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CoreMyApp.Repository.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected AppDbContext AppDbContext { get; set; }

        protected Repository(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public virtual IQueryable<TEntity> FindAll()
        {
            return AppDbContext.Set<TEntity>().AsNoTracking();
        }

        public virtual IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return AppDbContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public virtual EntityEntry<TEntity> Create(TEntity entity)
        {
            return AppDbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            AppDbContext.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            AppDbContext.Set<TEntity>().Remove(entity);
        }
    }
}