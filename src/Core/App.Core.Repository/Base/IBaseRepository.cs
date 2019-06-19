using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using App.Core.Entity;

namespace App.Core.Repository.Base
{
    public interface IBaseRepository<TEntity> where TEntity:BaseEntity
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> expression);

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
