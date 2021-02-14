using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ecormmerce.Web.Models.Orders
{
    public class UpdateOrderModel
    {
        public Guid Id { get; set; }
        public string Comments { get; set; }
        [Required]
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; }
        public Guid VehicleId { get; set; }
    }
}
