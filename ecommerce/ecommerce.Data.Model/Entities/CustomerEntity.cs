using System;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public class CustomerEntity : AuditEntity<Guid>
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => FirstName + " " + Surname;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLegalEntity { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double AnnualIncome { get; set; }
    }
}