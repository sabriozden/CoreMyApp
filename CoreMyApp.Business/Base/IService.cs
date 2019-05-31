using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using CoreMyApp.Business.Dto;

namespace CoreMyApp.Business.Base
{
    public interface IService
    {
    }

    public interface IService<TDto> : IService where TDto : BaseDto
    {
        List<TDto> FindAll();

        List<TDto> FindByCondition(TDto dto);

        TDto Create(TDto dto);

        void Update(TDto dto);

        void Delete(TDto dto);
    }
}