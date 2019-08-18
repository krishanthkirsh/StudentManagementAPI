using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class Course
        : Entity<int>
    {
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public double CourseFee { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }
}
