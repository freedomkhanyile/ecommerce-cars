using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Orders
{
    public class CreateOrderLineModel
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public bool IsAssembling { get; set; }
        public Guid OrderEntityId { get; set; }
        public string CreateUserId { get; set; }
        public string ModifyUserId { get; set; }
    }
}
