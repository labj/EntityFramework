using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Models;

namespace EntityFramework.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Teacher>().HasData(
              new Teacher { TeacherId = 1, Name = "Håkan Karlsson", PhoneNo = "0781-234567", Email = "håk@gmail.com" },
              new Teacher { TeacherId = 2, Name = "Brenda Allison", PhoneNo = "031-122334", Email = "ba@gmail.com" },
              new Teacher { TeacherId = 3, Name = "Hampus Svensson", PhoneNo = "0730-121314", Email = "hs@gmail.com" },
              new Teacher { TeacherId = 4, Name = "Ann Ek", PhoneNo = "0730-121444", Email = "ae@gmail.com" }
            );
            modelBuilder.Entity<Student>().HasData(
              new Student { StudentId = 1, Name = "Torkel Svensson", City = "Eskilstuna", PhoneNo = "0781-234568" },
              new Student { StudentId = 2, Name = "Lena Johansson", City = "Stockholm", PhoneNo = "031-122338" },
              new Student { StudentId = 3, Name = "Sean Johnson", City = "GBG", PhoneNo = "0730-121314" },
              new Student { StudentId = 4, Name = "Anna Bergh", City = "Malmö", PhoneNo = "0730-234555" },
              new Student { StudentId = 5, Name = "Rudolf Krokslätt", City = "GBG", PhoneNo = "0708-256777" },
              new Student { StudentId = 6, Name = "Helena Ackus", City = "GBG", PhoneNo = "0730-345888" }
            );
            modelBuilder.Entity<Assignment>().HasData(
              new Assignment { AssignmentId = 1, Title = "Matte 1.1", Subject = "Matematik gymnasiet", CourseId = 1 },
              new Assignment { AssignmentId = 2, Title = "Matte 1.2", Subject = "Matematik gymnasiet", CourseId = 1 },
              new Assignment { AssignmentId = 3, Title = "Svenska 1.1", Subject = "Svenska gymnasiet", CourseId = 2 }, 
              new Assignment { AssignmentId = 4, Title = "Matte 2.1", Subject = "Matematik gymnasiet", CourseId = 1 },
              new Assignment { AssignmentId = 5, Title = "Matte 2.2", Subject = "Matematik gymnasiet", CourseId = 1 },
              new Assignment { AssignmentId = 6, Title = "Svenska 1.2", Subject = "Svenska gymnasiet", CourseId = 2 },
              new Assignment { AssignmentId = 7, Title = "Spanska 1.1", Subject = "Spanska gymnasiet", CourseId = 3 },
              new Assignment { AssignmentId = 8, Title = "Spanska 1.2", Subject = "Spanska gymnasiet", CourseId = 3 },
              new Assignment { AssignmentId = 9, Title = "Spanska 2.1", Subject = "Spanska gymnasiet", CourseId = 3 }
            );
            modelBuilder.Entity<Course>().HasData(
              new Course { CourseId = 1, Title = "Matte", Subject = "Matematik gymnasiet", Points = 10, TeacherId = 1 },
              new Course { CourseId = 2, Title = "Svenska", Subject = "Svenska gymnasiet", Points = 5, TeacherId = 2 },
              new Course { CourseId = 3, Title = "Spanska", Subject = "Spanska gymnasiet", Points = 5, TeacherId = 3 },
              new Course { CourseId = 4, Title = "Idrott", Subject = "Idrott & Gymnastik", Points = 5, TeacherId = 4 }
            );
            modelBuilder.Entity<StudentCourse>().HasData(
              new StudentCourse { CourseId = 1, StudentId = 1 },
              new StudentCourse { CourseId = 2, StudentId = 2 },
              new StudentCourse { CourseId = 3, StudentId = 3 },
              new StudentCourse { CourseId = 4, StudentId = 1 },
              new StudentCourse { CourseId = 4, StudentId = 2 },
              new StudentCourse { CourseId = 4, StudentId = 3 },
              new StudentCourse { CourseId = 4, StudentId = 4 },
              new StudentCourse { CourseId = 4, StudentId = 5 },
              new StudentCourse { CourseId = 4, StudentId = 6 }
            );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
