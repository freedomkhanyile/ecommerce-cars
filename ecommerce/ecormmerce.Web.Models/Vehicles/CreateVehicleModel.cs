using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ecormmerce.Web.Models.Vehicles
{
    public class CreateVehicleModel
    {
        [Required]
        public string ModelName { get; set; }
        [Required]
        public string ModelYear { get; set; }
        [Required]
        public string BodyStyle { get; set; }
        public Guid ManufacturerEntityId { get; set; }
        public string CreateUserId { get; set; }
        public string ModifyUserId { get; set; }
    }
}
