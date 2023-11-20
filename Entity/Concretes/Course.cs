using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entity.Concretes
{
    public class Course : IEntities
    {
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
