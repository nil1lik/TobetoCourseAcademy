using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Instructor :IEntities
    {
        public int InstructorId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

    }
}
