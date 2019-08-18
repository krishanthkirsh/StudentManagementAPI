using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class StudentManagementDbContext : DbContext
    {
        public StudentManagementDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
    }
}
