using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Data.Model.BaseEntities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
