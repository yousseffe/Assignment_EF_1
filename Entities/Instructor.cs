using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF_1.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address   { get; set; }
        public float Bouns { get; set; }
        public float Salary { get; set; }
        public float HourRate { get; set; }
        public int Dept_ID { get; set; }
    }
}
