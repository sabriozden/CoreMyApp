using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Entity
{
    public interface ISoftDelete
    {
        bool Deleted { get; set; }
    }
}