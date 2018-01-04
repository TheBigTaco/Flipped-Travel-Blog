using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_experiences_locations_TravelBlog.Models.LocationId",
                table: "experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_people_experiences_TravelBlog.Models.ExperienceId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "TravelBlog.Models.ExperienceId",
                table: "people");

            migrationBuilder.DropColumn(
                name: "TravelBlog.Models.LocationId",
                table: "experiences");

            migrationBuilder.AddForeignKey(
                name: "FK_experiences_locations_LocationId",
                table: "experiences",
                column: "LocationId",
                principalTable: "locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_people_experiences_ExperienceId",
                table: "people",
                column: "ExperienceId",
                principalTable: "experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_experiences_locations_LocationId",
                table: "experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_people_experiences_ExperienceId",
                table: "people");

            migrationBuilder.AddColumn<int>(
                name: "TravelBlog.Models.ExperienceId",
                table: "people",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TravelBlog.Models.LocationId",
                table: "experiences",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_experiences_locations_TravelBlog.Models.LocationId",
                table: "experiences",
                column: "TravelBlog.Models.LocationId",
                principalTable: "locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_people_experiences_TravelBlog.Models.ExperienceId",
                table: "people",
                column: "TravelBlog.Models.ExperienceId",
                principalTable: "experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
