using App.Core.Dto.Base;
using FluentValidation;

namespace App.Core.Validator.Base
{
   

    public abstract class BaseDtoValidator<TDto> : AbstractValidator<TDto>
        where TDto : BaseDto
    {
    }
}
