using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Users
{
    public class UserModel
    {
        public UserModel()
        {
            Roles = new string[0];
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string UserToken { get; set; }
        public string ManufacturerEntityId { get; set; }
        public string[] Roles { get; set; }
    }
}
