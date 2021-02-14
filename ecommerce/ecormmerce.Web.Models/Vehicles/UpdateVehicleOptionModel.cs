using System;
using System.Collections.Generic;
using System.Text;

namespace ecormmerce.Web.Models.Vehicles
{
    public class UpdateVehicleOptionModel
    {
        public Guid VehicleEntityId { get; set; }
        public int OptionEntityId { get; set; }
    }
}
