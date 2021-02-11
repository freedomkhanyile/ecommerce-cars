using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data.Access.Maps.Common
{
    public interface IMap
    {
        void Visit(ModelBuilder builder);
    }
}
