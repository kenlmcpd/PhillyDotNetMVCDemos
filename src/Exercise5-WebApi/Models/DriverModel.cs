using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Excercise5_WebApi.Models
{
    public class DriverContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleModel).IsRequired();
            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleMakeId).IsRequired();
            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleTypeId).IsRequired();

            modelBuilder.Entity<VehicleType>().Property(v => v.VehicleTypeName).IsRequired();
            modelBuilder.Entity<VehicleMake>().Property(v => v.VehicleMakeName).IsRequired();

            modelBuilder.Entity<Driver>().Property(v => v.DriverName).IsRequired();
            modelBuilder.Entity<Driver>().Property(v => v.VehicleId).IsRequired();
        }

        public Microsoft.Data.Entity.DbSet<Vehicle> Vehicles { get; set; }
        public Microsoft.Data.Entity.DbSet<VehicleType> VehicleTypes { get; set; }
        public Microsoft.Data.Entity.DbSet<VehicleMake> VehicleMakes { get; set; }
        public Microsoft.Data.Entity.DbSet<Driver> Drivers { get; set; }
    }

    public class Vehicle
    {
        public Vehicle()
        {
            VehicleType = new VehicleType();
            VehicleMake = new VehicleMake();
        }

        public int Id { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleTypeId { get; set; }
        public int VehicleMakeId { get; set; }


        public virtual VehicleType VehicleType { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }

    public class VehicleType
    {
        public int Id { get; set; }
        public string VehicleTypeName { get; set; }
    }

    public class VehicleMake
    {
        public int Id { get; set; }
        public string VehicleMakeName { get; set; }
    }

    public class Driver
    {
        public Driver()
        {
            Vehicle = new Vehicle();
        }

        public int Id { get; set; }

        public string DriverName { get; set; }

        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
