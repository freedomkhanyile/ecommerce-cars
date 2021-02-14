using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Manufacturers
{
    public class ManufacturerModel
    {
        public Guid ManufacturerEntityId { get; set; }
        public string ManufacturerName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public int StockInHand { get; set; }
        public string Type { get; set; }
    }
}
