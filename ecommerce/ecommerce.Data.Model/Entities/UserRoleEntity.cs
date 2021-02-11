using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class UserRoleEntity: AuditEntity<int>
    {
        public Guid UserEntityId { get; set; }
        public int RoleEntityId { get; set; }
        public virtual UserEntity UserEntity { get; set; }
        public virtual RoleEntity Role { get; set; }
    }
}
