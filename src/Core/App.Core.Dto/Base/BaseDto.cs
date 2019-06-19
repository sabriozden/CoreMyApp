using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Dto.Base
{
    public abstract class BaseDto
    {
    }

    public interface IDto<TKey>
    {
        TKey Id { get; set; }
    }

    public class Dto<TKey> : BaseDto, IDto<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}