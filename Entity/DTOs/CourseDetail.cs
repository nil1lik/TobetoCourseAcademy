using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CourseDetail : IDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
