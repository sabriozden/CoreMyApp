using System;
using System.Linq;
using System.Linq.Expressions;
using App.Core.Entity;
using App.Core.Repository.DataContext;
using Microsoft.EntityFrameworkCore;

namespace App.Core.Repository.Base
{
    public abstract class Repository<TEntity> : BaseRepository<TEntity>, IRepository<TEntity> where TEntity : BaseEntity
    {
        

        protected Repository(BaseDatabaseContext databaseContext): base(databaseContext)
        {
            
        }

       

        public void SoftDelete<TSoftEntity>(TSoftEntity entity) where TSoftEntity : BaseEntity,ISoftDelete
        {
            entity.Deleted = true;
            DatabaseContext.Set<TSoftEntity>().Update(entity);
        }
    }
}