﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace student_management_api.Migrations
{
    public partial class AddStudentToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collegeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    year = table.Column<int>(type: "int", nullable: false),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearOfJoin = table.Column<int>(type: "int", nullable: false),
                    firstGraduate = table.Column<bool>(type: "bit", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rollNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsModel", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsModel");
        }
    }
}