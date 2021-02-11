using System;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class VehicleOptionEntity: AuditEntity<int>
    {
        public Guid VehicleEntityId { get; set; }
        public int OptionEntityId { get; set; }
        public virtual VehicleEntity Vehicle { get; set; }
        public virtual OptionEntity Option { get; set; }
    }
}