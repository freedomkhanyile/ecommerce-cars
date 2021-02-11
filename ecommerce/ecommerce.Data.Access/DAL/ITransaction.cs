using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Data.Access.DAL
{
    public interface ITransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
