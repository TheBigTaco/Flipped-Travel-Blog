using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "experiences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Description = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    Description = table.Column<string>(nullable: true),
                    ExperienceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_experiences_LocationId",
                table: "experiences",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_people_ExperienceId",
                table: "people",
                column: "ExperienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "people");

            migrationBuilder.DropTable(
                name: "experiences");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
