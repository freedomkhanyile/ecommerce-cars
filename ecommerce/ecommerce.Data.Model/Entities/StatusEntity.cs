using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class StatusEntity: AuditEntity<int>
    {
        public string StatusName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
