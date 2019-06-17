using App.Core.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace App.Core.Repository.Base
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository where TEntity : BaseEntity
    {
        IQueryable<TEntity> FindAll();

        IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}