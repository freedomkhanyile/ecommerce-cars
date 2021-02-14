using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Customer
{
    public class UpdateCustomerModel
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsLegalEntity { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public double AnnualIncome { get; set; }
        public string ModifyUserId { get; set; }
    }
}
