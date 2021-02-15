using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Users
{
    public class UserWithTokenModel
    {
        public UserModel User { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
