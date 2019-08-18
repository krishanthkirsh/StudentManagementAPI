using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class StudentCourse 
        : Entity<int>
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
