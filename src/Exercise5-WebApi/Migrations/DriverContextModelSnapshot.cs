using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Excercise5_WebApi.Models;

namespace Exercise5WebApi.Migrations
{
    [DbContext(typeof(DriverContext))]
    partial class DriverContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Excercise5_WebApi.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DriverName")
                        .IsRequired();

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Excercise5_WebApi.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("VehicleMakeId");

                    b.Property<string>("VehicleModel")
                        .IsRequired();

                    b.Property<int>("VehicleTypeId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Excercise5_WebApi.Models.VehicleMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VehicleMakeName")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Excercise5_WebApi.Models.VehicleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VehicleTypeName")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Excercise5_WebApi.Models.Driver", b =>
                {
                    b.HasOne("Excercise5_WebApi.Models.Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("Excercise5_WebApi.Models.Vehicle", b =>
                {
                    b.HasOne("Excercise5_WebApi.Models.VehicleMake")
                        .WithMany()
                        .HasForeignKey("VehicleMakeId");

                    b.HasOne("Excercise5_WebApi.Models.VehicleType")
                        .WithMany()
                        .HasForeignKey("VehicleTypeId");
                });
        }
    }
}
