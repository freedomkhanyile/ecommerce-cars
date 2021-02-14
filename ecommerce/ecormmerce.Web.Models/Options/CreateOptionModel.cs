﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ecormmerce.Web.Models.Options
{
    public class CreateOptionModel
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int QtyStock { get; set; }
        public Guid ManufacturerEntityId { get; set; }
        public string CreateUserId { get; set; }
        public string ModifyUserId { get; set; }
    }
}
