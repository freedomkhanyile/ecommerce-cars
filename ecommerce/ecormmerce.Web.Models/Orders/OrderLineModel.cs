using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Orders
{
    public class OrderLineModel
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public bool IsAssembling { get; set; }
        public Guid OrderEntityId { get; set; }
    }
}
