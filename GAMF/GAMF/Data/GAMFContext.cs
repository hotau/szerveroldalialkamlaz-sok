using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GAMF.Models;

namespace GAMF.Data
{
    public class GAMFContext : DbContext
    {
        public GAMFContext(DbContextOptions<GAMFContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // HasData metódus használatánál azoknak a tulajdonságoknak is értéket kell adni
            // mely egyébként automatikusan generálódnának (pl. azonosítók)

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 2, FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 3, FirstMidName = "Arturo", LastName = "Anand", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 4, FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 5, FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 6, FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 7, FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.UtcNow },
                new Student { Id = 8, FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1050, Title = "Chemistry", Credits = 3, },
                new Course { CourseId = 4022, Title = "Microeconomics", Credits = 3, },
                new Course { CourseId = 4041, Title = "Macroeconomics", Credits = 3, },
                new Course { CourseId = 1045, Title = "Calculus", Credits = 4, },
                new Course { CourseId = 3141, Title = "Trigonometry", Credits = 4, },
                new Course { CourseId = 2021, Title = "Composition", Credits = 3, },
                new Course { CourseId = 2042, Title = "Literature", Credits = 4, }
            );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 1050, Grade = Grade.A },
                new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 4022, Grade = Grade.C },
                new Enrollment { EnrollmentId = 3, StudentId = 1, CourseId = 4041, Grade = Grade.B },
                new Enrollment { EnrollmentId = 4, StudentId = 2, CourseId = 1045, Grade = Grade.B },
                new Enrollment { EnrollmentId = 5, StudentId = 2, CourseId = 3141, Grade = Grade.F },
                new Enrollment { EnrollmentId = 6, StudentId = 2, CourseId = 2021, Grade = Grade.F },
                new Enrollment { EnrollmentId = 7, StudentId = 3, CourseId = 1050 },
                new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 1050, },
                new Enrollment { EnrollmentId = 9, StudentId = 4, CourseId = 4022, Grade = Grade.F },
                new Enrollment { EnrollmentId = 10, StudentId = 5, CourseId = 4041, Grade = Grade.C },
                new Enrollment { EnrollmentId = 11, StudentId = 6, CourseId = 1045 },
                new Enrollment { EnrollmentId = 12, StudentId = 7, CourseId = 3141, Grade = Grade.A }
            );
        }
    }
}
