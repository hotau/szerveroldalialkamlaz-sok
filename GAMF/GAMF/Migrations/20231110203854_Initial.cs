﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GAMF.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Credits = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    FirstMidName = table.Column<string>(type: "text", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollment",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    Grade = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollment", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseId", "Credits", "Title" },
                values: new object[,]
                {
                    { 1045, 4, "Calculus" },
                    { 1050, 3, "Chemistry" },
                    { 2021, 3, "Composition" },
                    { 2042, 4, "Literature" },
                    { 3141, 4, "Trigonometry" },
                    { 4022, 3, "Microeconomics" },
                    { 4041, 3, "Macroeconomics" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2365), "Carson", "Alexander" },
                    { 2, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2375), "Meredith", "Alonso" },
                    { 3, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2384), "Arturo", "Anand" },
                    { 4, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2394), "Gytis", "Barzdukas" },
                    { 5, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2424), "Yan", "Li" },
                    { 6, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2433), "Peggy", "Justice" },
                    { 7, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2443), "Laura", "Norman" },
                    { 8, new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2453), "Nino", "Olivetto" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentId", "CourseId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 1, 1050, 0, 1 },
                    { 2, 4022, 2, 1 },
                    { 3, 4041, 1, 1 },
                    { 4, 1045, 1, 2 },
                    { 5, 3141, 4, 2 },
                    { 6, 2021, 4, 2 },
                    { 7, 1050, null, 3 },
                    { 8, 1050, null, 4 },
                    { 9, 4022, 4, 4 },
                    { 10, 4041, 2, 5 },
                    { 11, 1045, null, 6 },
                    { 12, 3141, 0, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollment");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
