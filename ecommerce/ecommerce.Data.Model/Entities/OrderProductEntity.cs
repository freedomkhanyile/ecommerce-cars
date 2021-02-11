using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class OrderProductEntity: AuditEntity<int>
    {
        public bool IsInStock { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public Guid OrderEntityId { get; set; }
        public Guid ProductEntityId { get; set; }
        public virtual OrderEntity Order { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
