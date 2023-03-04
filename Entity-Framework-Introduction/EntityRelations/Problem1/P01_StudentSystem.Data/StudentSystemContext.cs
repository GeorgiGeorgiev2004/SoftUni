using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using P01_StudentSystem.Data.Common;
using P01_StudentSystem.Data.Models;
using System.Collections.Generic;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }

        public StudentSystemContext()
        {

        }
        public StudentSystemContext(DbContextOptions options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(DBConfig.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentCourse>(e=>e
            .HasKey(pk=>new {pk.StudentId,pk.CourseId }));

            modelBuilder.Entity<StudentCourse>()
                .HasOne(a => a.Student)
                .WithMany(a => a.StudentsCourses)
                .HasForeignKey(a => a.StudentId);

         modelBuilder.Entity<StudentCourse>()
                       .HasOne(a => a.Course)
                       .WithMany(a => a.StudentsCourses)
                       .HasForeignKey(a => a.CourseId);

            modelBuilder.Entity<Student>()
               .HasMany(a => a.Homeworks)
               .WithOne(d => d.Student)
               .HasForeignKey(f => f.StudentId);

            modelBuilder.Entity<Course>()
               .HasMany(a => a.Resources)
               .WithOne(a => a.Course)
               .HasForeignKey(a => a.CourseId);

            modelBuilder.Entity<Course>()
               .HasMany(a => a.Homeworks)
               .WithOne(a => a.Course)
               .HasForeignKey(a => a.CourseId);
        }
    }
}