﻿// <auto-generated />
using System;
using GAMF.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GAMF.Migrations
{
    [DbContext(typeof(GAMFContext))]
    [Migration("20231110203854_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GAMF.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CourseId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1050,
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            CourseId = 4022,
                            Credits = 3,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            CourseId = 4041,
                            Credits = 3,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            CourseId = 1045,
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            CourseId = 3141,
                            Credits = 4,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            CourseId = 2021,
                            Credits = 3,
                            Title = "Composition"
                        },
                        new
                        {
                            CourseId = 2042,
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("GAMF.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int?>("Grade")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollment");

                    b.HasData(
                        new
                        {
                            EnrollmentId = 1,
                            CourseId = 1050,
                            Grade = 0,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 2,
                            CourseId = 4022,
                            Grade = 2,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 3,
                            CourseId = 4041,
                            Grade = 1,
                            StudentId = 1
                        },
                        new
                        {
                            EnrollmentId = 4,
                            CourseId = 1045,
                            Grade = 1,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 5,
                            CourseId = 3141,
                            Grade = 4,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 6,
                            CourseId = 2021,
                            Grade = 4,
                            StudentId = 2
                        },
                        new
                        {
                            EnrollmentId = 7,
                            CourseId = 1050,
                            StudentId = 3
                        },
                        new
                        {
                            EnrollmentId = 8,
                            CourseId = 1050,
                            StudentId = 4
                        },
                        new
                        {
                            EnrollmentId = 9,
                            CourseId = 4022,
                            Grade = 4,
                            StudentId = 4
                        },
                        new
                        {
                            EnrollmentId = 10,
                            CourseId = 4041,
                            Grade = 2,
                            StudentId = 5
                        },
                        new
                        {
                            EnrollmentId = 11,
                            CourseId = 1045,
                            StudentId = 6
                        },
                        new
                        {
                            EnrollmentId = 12,
                            CourseId = 3141,
                            Grade = 0,
                            StudentId = 7
                        });
                });

            modelBuilder.Entity("GAMF.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2365),
                            FirstMidName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2375),
                            FirstMidName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            Id = 3,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2384),
                            FirstMidName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            Id = 4,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2394),
                            FirstMidName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            Id = 5,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2424),
                            FirstMidName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            Id = 6,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2433),
                            FirstMidName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            Id = 7,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2443),
                            FirstMidName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            Id = 8,
                            EnrollmentDate = new DateTime(2023, 11, 10, 20, 38, 54, 655, DateTimeKind.Utc).AddTicks(2453),
                            FirstMidName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("GAMF.Models.Enrollment", b =>
                {
                    b.HasOne("GAMF.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GAMF.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GAMF.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("GAMF.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}