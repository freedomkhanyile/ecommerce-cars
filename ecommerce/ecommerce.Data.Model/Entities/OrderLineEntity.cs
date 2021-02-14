using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class OrderLineEntity: AuditEntity<int>
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public bool IsAssembling { get; set; }
        public Guid OrderEntityId { get; set; }
        public virtual OrderEntity Order { get; set; }
    }
}
