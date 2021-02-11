using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class CompanyEntity: AuditEntity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int ProductsInStock { get; set; }
        public int ParentCompanyId { get; set; }
    }
}
