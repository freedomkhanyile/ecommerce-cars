using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Vehicles
{
    public class CreateVehicleOptionModel
    {
        public Guid VehicleEntityId { get; set; }
        public int OptionEntityId { get; set; }
        public string CreateUserId { get; set; }
        public string ModifyUserId { get; set; }
        public int StatusId { get; set; }
    }
}
