using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Security.Contracts
{
    public interface ITokenBuilder
    {
        string Build(string name, string[] roles, DateTime expireDate);
    }
}
