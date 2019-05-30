using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMyApp.Entities.Base
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}