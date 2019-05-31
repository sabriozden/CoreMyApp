using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using CoreMyApp.Entities.Base;
using CoreMyApp.Repository.Base;

namespace CoreMyApp.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private Dictionary<Type, dynamic> _repositories;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public TRepository Repository<TRepository, TEntity>() where TRepository : Repository<TEntity>
        //    where TEntity : BaseEntity
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