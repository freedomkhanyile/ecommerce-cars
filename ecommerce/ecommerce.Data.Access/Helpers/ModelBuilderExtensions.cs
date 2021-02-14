using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Access.constants;
using ecommerce.Data.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Data.Access.Helpers
{
    public static class ModelBuilderExtensions
    {
        public static void SeedRoleData(this ModelBuilder builder)
        {
            builder.Entity<RoleEntity>().HasData(
                new RoleEntity
                {
                    Id = 1,
                    RoleName = RoleConstants.Admin,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                },
                new RoleEntity
                {
                    Id = 2,
                    RoleName = RoleConstants.Manufacturer,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                },
                new RoleEntity
                {
                    Id = 3,
                    RoleName = RoleConstants.Customer,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                });
        }

        public static void SeedManufacturerData(this ModelBuilder builder)
        {
            builder.Entity<ManufacturerEntity>().HasData(
                new ManufacturerEntity
                {
                    Id = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                    ManufacturerName = "Volivo Motors",
                    Telephone = "01401245122",
                    Address = "New Land, Car Street 900",
                    StockInHand = 99,
                    Type = ManufacturerConstants.MainOffice,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                }, 
                new ManufacturerEntity
                {
                    Id = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251115"),
                    ManufacturerName = "Volivo Factory 1",
                    Telephone = "01245487541",
                    Address = "New Land, Factory street",
                    StockInHand = 99,
                    Type = ManufacturerConstants.Factory,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                },      
                new ManufacturerEntity
                {
                    Id = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251995"),
                    ManufacturerName = "Volivo Factory 2",
                    Telephone = "01401245122",
                    Address = "New Land, Factory street 2",
                    StockInHand = 99,
                    Type = ManufacturerConstants.Factory,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                },  
                new ManufacturerEntity
                {
                    Id = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc423725177"),
                    ManufacturerName = "Volivo Warehouse",
                    Telephone = "01401245122",
                    Address = "New Land, Warehouse Street 900",
                    StockInHand = 99,
                    Type = ManufacturerConstants.WareHouse,
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                }
            );
        }

        public static void SeedUserData(this ModelBuilder builder)
        {
            var defaultPassword = "12345";
            builder.Entity<UserEntity>().HasData(new UserEntity
            {
                Id = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                Email = "admin@mail.com",
                FirstName = "john",
                Surname = "Doe",
                Password = defaultPassword.WithBCrypt(),
                ManufacturerEntityId = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251445"),
                CreateDate = DateTime.Now,
                CreateUserId = "System",
                ModifyDate = DateTime.Now,
                ModifyUserId = "System",
                StatusId = 1
            });
        }

        public static void SeedUserRoleData(this ModelBuilder builder)
        {
            builder.Entity<UserRoleEntity>().HasData(
                new UserRoleEntity
                {
                    Id = 1,
                    RoleEntityId = 1,
                    UserEntityId = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251335"),
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                }
            );
        }


        #region Seed vehicle options

        public static void SeedOptionData(this ModelBuilder builder)
        {
            builder.Entity<OptionEntity>().HasData(

                new OptionEntity
                {
                    Id = 1,
                    Name = "Engine",
                    Code = "ENG-COMP",
                    Value = "V12 Engine",
                    ManufacturerEntityId = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251115"),
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                },  
                new OptionEntity
                {
                    Id = 2,
                    Name = "Chasis",
                    Code = "CHA-COMP",
                    ManufacturerEntityId = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251115"),
                    Value = "Ladder Frame",
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                }, 
                new OptionEntity
                {
                    Id = 3,
                    Name = "Option Pack",
                    Code = "OPT-COMP",
                    Value = "Performance Package",
                    ManufacturerEntityId = Guid.Parse("c6e641f7-ce8d-4de5-aef7-bc4237251115"),
                    CreateDate = DateTime.Now,
                    CreateUserId = "System",
                    ModifyDate = DateTime.Now,
                    ModifyUserId = "System",
                    StatusId = 1
                }
            );

        }
        

        #endregion
    }
}
