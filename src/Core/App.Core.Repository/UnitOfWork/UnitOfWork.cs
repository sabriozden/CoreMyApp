using System;
using System.Collections.Generic;
using App.Core.Repository.Base;
using App.Core.Repository.DataContext;

namespace App.Core.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BaseDatabaseContext _dbContext;
        private Dictionary<Type, dynamic> _repositories;

        public UnitOfWork(BaseDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        public TRepository Repository<TRepository>() where TRepository : IRepository
        {
            if (_repositories == null)
                _repositories = new Dictionary<Type, dynamic>();
            var type = typeof(TRepository);
            if (_repositories.ContainsKey(type))
                return (TRepository)_repositories[type];
            _repositories.Add(type, Activator.CreateInstance(typeof(TRepository), _dbContext));
            return _repositories[type];
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }

    public interface IUnitOfWork
    {
        TRepository Repository<TRepository>() where TRepository : IRepository;

        int SaveChanges();
    }
}