﻿using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Access.Maps.Common;
using ecommerce.Data.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data.Access.Maps
{
    public class ManufacturerMap: IMap
    {
        public void Visit(ModelBuilder builder)
        {
            builder.Entity<ManufacturerEntity>()
                .ToTable("Manufacturers")
                .HasKey(x => x.Id);
        }
    }
}
