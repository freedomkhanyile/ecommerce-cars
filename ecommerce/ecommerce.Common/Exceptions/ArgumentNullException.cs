using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Common.Exceptions
{
    public class ArgumentNullException : Exception
    {
        public ArgumentNullException(string message) : base(message)
        {
        }
    }
}
