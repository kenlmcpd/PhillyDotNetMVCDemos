using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Exercise5WebApi.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Driver_Vehicle_VehicleId", table: "Driver");
            migrationBuilder.DropForeignKey(name: "FK_Vehicle_VehicleMake_VehicleMakeId", table: "Vehicle");
            migrationBuilder.DropForeignKey(name: "FK_Vehicle_VehicleType_VehicleTypeId", table: "Vehicle");
            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Vehicle_VehicleId",
                table: "Driver",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId",
                principalTable: "VehicleMake",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Driver_Vehicle_VehicleId", table: "Driver");
            migrationBuilder.DropForeignKey(name: "FK_Vehicle_VehicleMake_VehicleMakeId", table: "Vehicle");
            migrationBuilder.DropForeignKey(name: "FK_Vehicle_VehicleType_VehicleTypeId", table: "Vehicle");
            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Vehicle_VehicleId",
                table: "Driver",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleMake_VehicleMakeId",
                table: "Vehicle",
                column: "VehicleMakeId",
                principalTable: "VehicleMake",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_VehicleType_VehicleTypeId",
                table: "Vehicle",
                column: "VehicleTypeId",
                principalTable: "VehicleType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
