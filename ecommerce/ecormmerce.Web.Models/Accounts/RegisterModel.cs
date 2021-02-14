using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ecormmerce.Web.Models.Accounts
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public bool IsLegalEntity { get; set; }
        [Required]
        public string Address { get; set; }
        public string City { get; set; }
        public string[] Roles { get; set; }
        public string ManufaturerId { get; set; }
        public string CreateUserId { get; set; }
        public string ModifyUserId { get; set; }
    }
}
