using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public interface ICourseRepository
    {
        List<Course> List();
        Course FindById(object Id);
        string Add(Course entity);
        string Update(Course entity);
        void Delete(Course entity);
        void Save();
    }
}
