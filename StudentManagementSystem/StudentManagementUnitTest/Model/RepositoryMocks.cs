using Moq;
using StudentManagement.DataLayer;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
                        CourseName ="ASP.NET CORE",
                        CourseDuration = "aspnetcore",
                        CourseFee = 2500,
                        StudentCourses =null
                },
                new Course
                {
                    Id = 2,
                    CourseName = "SQL SERVER",
                    CourseDuration = "sqlserver",
                    CourseFee = 2200,
                    StudentCourses =null
                }
            };
            var mokeCourseRepository = new Mock<ICourseRepository>();
            mokeCourseRepository.Setup(repo => repo.List()).Returns(course);
            mokeCourseRepository.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(course[0]);
            mokeCourseRepository.Setup(repo => repo.Add(It.IsAny<Course>())).Returns((Course target) => { course.Add(target); return target.Id.ToString(); });
            mokeCourseRepository.Setup(repo => repo.Update(It.IsAny<Course>())).Returns(
            (Course target) =>
            {
                var updatcourse = course.Where(p => p.Id == target.Id).FirstOrDefault();
                if (course == null)
                {
                    return "Empty";
                }
                updatcourse.CourseName = target.CourseName;
                updatcourse.CourseDuration = target.CourseDuration;
                updatcourse.CourseFee = target.CourseFee;
                return target.Id.ToString();
            });
            mokeCourseRepository.Setup(repo => repo.Delete(It.IsAny<Course>())).Returns((int Id) => {
                var Delobj = course.Where(x => x.Id == Id).FirstOrDefault();
                if(course == null)
                {
                    return "UnSuccessFull";
                }
                course.Remove(Delobj);
                return "Success";
            });
            return mokeCourseRepository;
        }
    }
}
