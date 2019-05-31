using CoreMyApp.Business.Dto;
using CoreMyApp.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using CoreMyApp.Entities.Base;
using CoreMyApp.Repository.Base;

namespace CoreMyApp.Business.Base
{
    public abstract class Service<TRepository, TEntity, TDto> : IService<TDto>
        where TDto : BaseDto
        where TRepository : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public TDto Create(TDto dto)
        {
            //TODO: implementasyonu tamamlanacak.
            var t = UnitOfWork.Repository<TRepository>().Create(default(TEntity));
            return default(TDto);
        }

        public void Delete(TDto dto)
        {
            throw new NotImplementedException();
        }

        public List<TDto> FindAll()
        {
            throw new NotImplementedException();
        }

        public List<TDto> FindByCondition(TDto dto)
        {
            throw new NotImplementedException();
        }

        public void Update(TDto dto)
        {
            throw new NotImplementedException();
        }
    }
}