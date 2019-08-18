using Moq;
using StudentManagement.Controllers;
using StudentManagement.DataLayer;
using StudentManagement.Model;
using StudentManagementUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StudentManagementUnitTest
{
    public class UnitTest1
    {
        List<Course> expectedProducts;
        Mock<ICourseRepository> mockCourseRepository;
        CourseController courseController;
        [Fact]
        public void InitializeTestData()
        {
            expectedProducts = GetExpectedCourses();
            //Arrange
            mockCourseRepository = new Mock<ICourseRepository>();
            courseController = new CourseController(mockCourseRepository.Object);
            mockCourseRepository.Setup(m => m.List()).Returns(expectedProducts);
            mockCourseRepository.Setup(m => m.Add(It.IsAny<Course>())).Returns(
              (Course target) =>
              {
                  expectedProducts.Add(target);
                  return target.Id.ToString();
              });
            mockCourseRepository.Setup(m => m.Update(It.IsAny<Course>())).Returns(
           (Course target) =>
           {
               var course = expectedProducts.Where(p => p.Id == target.Id).FirstOrDefault();

               if (course == null)
               {
                   return "Empty";
               }

               course.CourseName = target.CourseName;
               course.CourseDuration = target.CourseDuration;
               course.CourseFee = target.CourseFee;

               return target.Id.ToString();
           });

        }
        [Fact]
        public void GetAllCourse()
        {
            InitializeTestData();
            //Act
            var actualProducts = courseController.Get();
            //Assert
            Assert.Same(expectedProducts, actualProducts);
        }

        private static List<Course> GetExpectedCourses()
        {
            return new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    CourseName = "N1",
                    CourseDuration = "C1",
                    CourseFee = 11,
                    StudentCourses = null
                },
                new Course()
                {
                    Id = 2,
                    CourseName = "N2",
                    CourseDuration = "C2",
                    CourseFee = 22,
                    StudentCourses =null
                }
            };
        }
    }
}
