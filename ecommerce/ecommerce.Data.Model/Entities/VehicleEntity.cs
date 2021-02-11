using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class VehicleEntity: AuditEntity<Guid>
    {
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public string BodyStyle { get; set; }
        public Guid ManufacturerEntityId { get; set; }
        public virtual ManufacturerEntity Manufacturer { get; set; }
    }
}
