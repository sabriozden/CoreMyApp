using System.Collections.Generic;
using App.Core.Dto.Base;

namespace App.Core.Business.Base
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