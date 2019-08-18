using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
    }
}
