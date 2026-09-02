using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_CodeFirst
{
    internal class Student
    {
        [Key]
        public int Roll { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
