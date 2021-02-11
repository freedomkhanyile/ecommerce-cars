using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
   public class RoleEntity : AuditEntity<int>
    {
        public string RoleName { get; set; }
    }
}
