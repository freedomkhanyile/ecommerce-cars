using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.Entities;

namespace ecommerce.Security
{
    public interface ISecurityContext
    {
        UserEntity UserEntity { get; }
        bool IsAdministrator { get; }
        bool IsStaff { get; }
        bool IsCustomer { get; }
    }
}
