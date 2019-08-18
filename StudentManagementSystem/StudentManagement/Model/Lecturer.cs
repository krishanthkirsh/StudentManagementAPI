using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class Lecturer 
        : Entity<int>
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string SubjectName { get; set; }
        public int ? CourseID { get; set; }
        public IEnumerable<Course> Course { get; set; }

    }
}
