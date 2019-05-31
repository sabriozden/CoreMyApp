using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMyApp.Business.Dto
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