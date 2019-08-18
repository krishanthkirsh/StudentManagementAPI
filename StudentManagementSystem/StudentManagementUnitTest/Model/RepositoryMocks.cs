using Moq;
using StudentManagement.DataLayer;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementUnitTest.Model
{
     public class RepositoryMocks
    {
        public static Mock<ICourseRepository> GetCourseRepository()
        {
            var course = new List<Course>
            {
                new Course
                {
                        Id = 1,
                        CourseName ="SQL",
                        CourseDuration = "Null",
                        CourseFee = 2500
                }
            };
            var mokeCourseRepository = new Mock<ICourseRepository>();
            return mokeCourseRepository;
        }
    }
}
