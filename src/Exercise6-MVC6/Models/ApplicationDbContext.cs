using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace Demo7_MVC6.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public Microsoft.Data.Entity.DbSet<Vehicle> Vehicles { get; set; }
        public Microsoft.Data.Entity.DbSet<VehicleType> VehicleTypes { get; set; }
        public Microsoft.Data.Entity.DbSet<VehicleMake> VehicleMakes { get; set; }
        public Microsoft.Data.Entity.DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleModel).IsRequired();
            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleMakeId).IsRequired();
            modelBuilder.Entity<Vehicle>().Property(v => v.VehicleTypeId).IsRequired();

            modelBuilder.Entity<VehicleType>().Property(v => v.VehicleTypeName).IsRequired();
            modelBuilder.Entity<VehicleMake>().Property(v => v.VehicleMakeName).IsRequired();

            modelBuilder.Entity<Driver>().Property(v => v.DriverName).IsRequired();
            modelBuilder.Entity<Driver>().Property(v => v.VehicleId).IsRequired();
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
