using StudentManagement.DataLayer;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementUnitTest.Model
{
    public class DummyDataDBInitializer
    {
        public DummyDataDBInitializer()
        { }

        public void Seed(StudentManagementDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Courses.AddRange(
                new Course() {Id=1, CourseName = "CSHARP", CourseDuration = "csharp" ,CourseFee = 200},
                new Course() { Id = 2, CourseName = "VISUAL STUDIO", CourseDuration = "visualstudio", CourseFee = 200 },
                new Course() { Id = 3, CourseName = "ASP.NET CORE", CourseDuration = "aspnetcore", CourseFee = 200 },
                new Course() { Id = 4, CourseName = "SQL SERVER", CourseDuration = "sqlserver", CourseFee = 200 }
            );
            context.SaveChanges();
        }
    }
}

