using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using Excercise5_WebApi.Models;

namespace Excercise5_WebApi.Controllers
{
    [Route("api/Drivers")]
    public class DriversApiController : Controller
    {
        private DriverContext _context;

        public DriversApiController(DriverContext context)
        {
            _context = context;

        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<DriverInfo> Get()
        {
            var resultSet = new List<DriverInfo>();
            var drivers = _context.Drivers.ToList();

            foreach (var driver in drivers)
            {
                var vehicle = _context.Vehicles.FirstOrDefault(v => v.Id == driver.VehicleId);
                var make = _context.VehicleMakes.FirstOrDefault(v => v.Id == vehicle.VehicleMakeId);
                var vehType = _context.VehicleTypes.FirstOrDefault(v => v.Id == vehicle.VehicleMakeId);

                try
                {
                    resultSet.Add(
                        new DriverInfo
                        {
                            DriverId = driver.Id,
                            DriverName = driver.DriverName,
                            Manufacture = (make != null) ? make.VehicleMakeName : "unknown",
                            Model = (vehicle != null) ? vehicle.VehicleModel : "unknown",
                            VehicleType = (vehType != null) ? vehType.VehicleTypeName : "unknown"
                        });
                }
                catch (Exception ex)
                {
                    var badnews = ex.Message;
                }
            }
            
            return resultSet;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public DriverInfo Get(int id)
        {
            var driver = _context.Drivers.FirstOrDefault(d => d.Id == id);
            if (driver == null) return new DriverInfo();

            var vehicle = _context.Vehicles.First(v => v.Id == driver.VehicleId);
            var vehicleMake = _context.VehicleMakes.First(v => v.Id == vehicle.VehicleMakeId);
            var vehicleType = _context.VehicleTypes.First(v => v.Id == vehicle.VehicleTypeId);

            return new DriverInfo
            {
                DriverId = driver.Id,
                DriverName = driver.DriverName,
                Manufacture = vehicleMake.VehicleMakeName,
                Model = vehicle.VehicleModel,
                VehicleType = vehicleType.VehicleTypeName
            };
        }

        // POST api/values
        [HttpPost]
        public System.Net.HttpStatusCode Post([FromBody]DriverInfo driverInfo)
        {
            var vehicleType = new VehicleType { VehicleTypeName = driverInfo.VehicleType };
            var vehicleMake = new VehicleMake { VehicleMakeName = driverInfo.Manufacture };
            var vehicle = new Vehicle { VehicleMake = vehicleMake, VehicleModel = driverInfo.Model, VehicleType = vehicleType };
            var driver = new Driver { DriverName = driverInfo.DriverName, Vehicle = vehicle };

            _context.Drivers.Add(driver)
                .Context.Add(vehicle)
                .Context.Add(vehicleMake)
                .Context.Add(vehicleType);

            var count = _context.SaveChanges();

            return System.Net.HttpStatusCode.NoContent;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public System.Net.HttpStatusCode Put(int id, [FromBody]DriverInfo driverInfo)
        {
            var driver = _context.Drivers.FirstOrDefault(d => d.Id == id);
            if (driver == null) return System.Net.HttpStatusCode.NotFound;

            var vehicle = _context.Vehicles.First(v => v.Id == driver.VehicleId);
            var vehicleMake = _context.VehicleMakes.First(v => v.Id == vehicle.VehicleMakeId);
            var vehicleType = _context.VehicleTypes.First(v => v.Id == vehicle.VehicleTypeId);

            vehicleType.VehicleTypeName = (driverInfo.VehicleType != vehicleType.VehicleTypeName) ? driverInfo.VehicleType : vehicleType.VehicleTypeName;
            vehicleMake.VehicleMakeName = (driverInfo.Manufacture != vehicleMake.VehicleMakeName) ? driverInfo.Manufacture : vehicleMake.VehicleMakeName;
            vehicle.VehicleModel = (driverInfo.Model != vehicle.VehicleModel) ? driverInfo.Model : vehicle.VehicleModel;
            driver.DriverName = (driverInfo.DriverName != driver.DriverName) ? driverInfo.DriverName : driver.DriverName;

            var count = _context.SaveChanges();

            return System.Net.HttpStatusCode.NoContent;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public System.Net.HttpStatusCode Delete(int id)
        {
            var driver = _context.Drivers.FirstOrDefault(d => d.Id == id);
            if (driver == null) return System.Net.HttpStatusCode.NotFound;

            var vehicle = _context.Vehicles.First(v => v.Id == driver.VehicleId);
            var vehicleMake = _context.VehicleMakes.First(v => v.Id == vehicle.VehicleMakeId);
            var vehicleType = _context.VehicleTypes.First(v => v.Id == vehicle.VehicleTypeId);

            _context.Vehicles.Remove(vehicle);
            _context.VehicleMakes.Remove(vehicleMake);
            _context.VehicleTypes.Remove(vehicleType);
            _context.Drivers.Remove(driver);

            var count = _context.SaveChanges();
            return System.Net.HttpStatusCode.OK;
        }
    }
}
