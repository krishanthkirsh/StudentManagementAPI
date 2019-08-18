using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.DataLayer;
using StudentManagement.Model;

namespace StudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this._courseRepository = courseRepository;
        }

        [HttpGet]
        public IList<Course> Get()
        {
            return _courseRepository.List();
        }

        [HttpPost]
        public string Post(Course Obj)
        {
            return _courseRepository.Add(Obj);
        }
    }
}