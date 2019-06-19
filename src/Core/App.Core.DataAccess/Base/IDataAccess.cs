using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace App.Core.DataAccess.Base
{

    public interface IDataAccess { }
    public interface IDataAccess<TEntity> : IDataAccess
    {

        IEnumerable<TEntity> FindAll();

        IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);

        TEntity Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
