using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class Student 
        : Entity<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string DateOfBirth { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }

    }

}
