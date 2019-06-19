
using System;
using System.Collections.Generic;
using App.Core.Dto.Base;
using App.Core.Entity;
using App.Core.Repository.UnitOfWork;


namespace App.Core.Business.Base
{
    public abstract class Service<TEntity, TDto> : IService<TDto>
        where TEntity: BaseEntity
        where TDto : BaseDto

       
    {
        protected readonly IUnitOfWork UnitOfWork;

        protected Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public TDto Create(TDto dto)
        {
            //TODO: Mapper uygulanacak.
            //TODO: implementasyonu tamamlanacak.
           
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