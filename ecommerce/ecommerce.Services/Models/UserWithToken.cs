using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.Entities;

namespace ecommerce.Services.Models
{
    public class UserWithToken
    {
        public string Token { get; set; }
        public UserEntity User { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
