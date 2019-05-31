using CoreMyApp.Entities.Base;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CoreMyApp.Repository.Base
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository where TEntity : BaseEntity
    {
        IQueryable<TEntity> FindAll();

        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);

        EntityEntry<TEntity> Create(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}