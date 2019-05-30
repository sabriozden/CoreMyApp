using System;
using System.Collections.Generic;
using System.Text;

namespace CoreMyApp.Entities.Base
{
    public interface ISoftDelete
    {
        bool Deleted { get; set; }
    }
}