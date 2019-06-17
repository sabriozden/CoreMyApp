using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entity
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}