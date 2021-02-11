using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class OrderEntity: AuditEntity<Guid>
    {
        public string Comments { get; set; }
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserEntityId { get; set; }
    }
}
