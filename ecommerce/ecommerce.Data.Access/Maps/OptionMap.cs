﻿using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Access.Maps.Common;
using ecommerce.Data.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data.Access.Maps
{
    public class OptionMap: IMap
    {
        public void Visit(ModelBuilder builder)
        {
            builder.Entity<OptionEntity>()
                .ToTable("Options")
                .HasKey(x => x.Id);
        }
    }
}
