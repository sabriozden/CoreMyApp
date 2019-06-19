using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using App.Core.Entity;
using App.Core.Repository.UnitOfWork;

namespace App.Core.DataAccess.Base
{
    public abstract class BaseDataAccess<TEntity>: IDataAccess<TEntity> where TEntity: BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        protected BaseDataAccess(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
