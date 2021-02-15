using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Access.Helpers;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data.Access.DAL
{
    public class MainDbContext: DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mappings = MappingsHelper.GetMainMappings();

            foreach (var mapping in mappings)
            {
                mapping.Visit(modelBuilder);
            }

            modelBuilder.SeedRoleData();
            modelBuilder.SeedUserData();
            modelBuilder.SeedUserRoleData();

            modelBuilder.SeedManufacturerData();
            modelBuilder.SeedOptionData();
            modelBuilder.SeedVehicleData();
            modelBuilder.SeedVehicleOptionsData();

            modelBuilder.SeedCustomerData();
      

        }
    }
}
