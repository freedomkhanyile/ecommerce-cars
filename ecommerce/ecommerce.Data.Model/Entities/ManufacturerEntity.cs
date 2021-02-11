using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class ManufacturerEntity: AuditEntity<Guid>
    {
        public string ManufacturerName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int StockInHand { get; set; }
    }
}
