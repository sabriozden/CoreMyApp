using App.Core.Entity;
using FluentValidation;

namespace App.Core.Validator
{
    public abstract class BaseEntityValidator<TEntity> : AbstractValidator<TEntity> 
        where TEntity:BaseEntity
    {
    }
}
