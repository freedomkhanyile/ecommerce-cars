using System;
using System.Collections.Generic;
using System.Text;

namespace ecommerce.Data.Model.BaseEntities
{
    public interface IAuditEntity
    {
        string CreateUserId { get; set; }
        DateTime CreateDate { get; set; }
        string ModifyUserId { get; set; }
        DateTime ModifyDate { get; set; }
        int StatusId { get; set; }
    }
}
