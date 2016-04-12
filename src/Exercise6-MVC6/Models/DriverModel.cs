using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace Demo7_MVC6.Models
{
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
