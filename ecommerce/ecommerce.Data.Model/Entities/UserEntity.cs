using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class UserEntity: AuditEntity<Guid>
    {
        public UserEntity()
        {
            Roles = new List<UserRoleEntity>();
        }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => FirstName + " " + Surname;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string UserToken { get; set; }

        public virtual IEnumerable<UserRoleEntity> Roles { get; set; }
    }
}
