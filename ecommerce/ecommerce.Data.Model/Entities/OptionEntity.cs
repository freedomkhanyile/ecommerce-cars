using System;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class OptionEntity: AuditEntity<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Guid ManufacturerEntityId { get; set; }
        public virtual ManufacturerEntity Manufacturer { get; set; }
    }
}