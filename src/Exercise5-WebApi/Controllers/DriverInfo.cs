using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo6_WebApi.Controllers
{
    public class DriverInfo
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string VehicleType { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
    }
}
