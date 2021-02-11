using System;
using System.Collections.Generic;
using System.Text;
using ecommerce.Data.Model.BaseEntities;

namespace ecommerce.Data.Model.Entities
{
    public abstract class ProductEntity: AuditEntity<Guid>
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public bool IsReserved { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
    }

    public class VehicleEntity : ProductEntity
    {
        public string VinNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string PaintColor { get; set; }
        public bool IsAssembled { get; set; }
    }

    public class EngineEntity : ProductEntity
    {
        public string EngineCode { get; set; }
        public string PetrolType { get; set; }
        public string HorsePower { get; set; }
    } 
    public class Chassis : ProductEntity
    {
    } 
    public class Package : ProductEntity
    {
    }
}
