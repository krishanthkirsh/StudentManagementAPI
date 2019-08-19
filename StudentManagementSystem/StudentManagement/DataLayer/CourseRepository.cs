using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.DataLayer
{
    public class CourseRepository : ICourseRepository
    {
        private StudentManagementDbContext _dBConn;
        internal DbSet<Course> dbSet;

        public CourseRepository(StudentManagementDbContext dBContext)
        {
            this._dBConn = dBContext;
            this.dbSet = dBContext.Set<Course>();
        }
        public List<Course> List()
        {
            return dbSet.ToList();
        }

        public Course FindById(object Id)
        {
            return dbSet.Find(Id);
        }

        public string Add(Course entity)
        {
            dbSet.Add(entity);
            Save();
            return entity.Id.ToString();
        }

        public string Update(Course entity)
        {
            dbSet.Attach(entity);
            _dBConn.Entry(entity).State = EntityState.Modified;
            Save();
            return entity.Id.ToString();
        }

        public string Delete(Course entity)
        {
            dbSet.Remove(entity);
            Save();
            return "Success";
        }

        public void Save()
        {
            _dBConn.SaveChanges();
        }
    }
}
