using Moq;
using StudentManagement.Controllers;
using StudentManagement.DataLayer;
using StudentManagement.Model;
using StudentManagementUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StudentManagementUnitTest
{
    public class CourseUnitTestController
    {

        [Fact]
        public void GetCourse()
        {
            var mockCourseRepository = RepositoryMocks.GetCourseRepository();
            var courseController = new CourseController(mockCourseRepository.Object);
            //Act
            var result = courseController.Get();
            //Assert
            //Assert.IsType<List<Course>>(result);
            var items = Assert.IsType<List<Course>>(result);
            Assert.Equal(2, items.Count);
        }

    }
}
