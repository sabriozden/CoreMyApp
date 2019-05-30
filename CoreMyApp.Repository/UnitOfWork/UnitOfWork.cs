using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using CoreMyApp.Entities.Base;
using CoreMyApp.Repository.Base;

namespace CoreMyApp.Repository.UnitOfWork
{
    public class UnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private Dictionary<Type, dynamic> _repositories;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity, new()
        {
            if (_repositories == null)
                _repositories = new Dictionary<Type, dynamic>();
            var type = typeof(TEntity);
            if (_repositories.ContainsKey(type))
                return (IRepository<TEntity>)_repositories[type];
            _repositories.Add(type, Activator.CreateInstance(typeof(Repository<TEntity>), _dbContext));
            return _repositories[type];
        }

        public void SaveChanges()
        {
        }
    }
}