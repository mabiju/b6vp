using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_console_ef_codefirst
{
    internal class StudentContext : DbContext
    {
        public StudentContext() : base()
        {
        
        }
        public DbSet<Student> Students { get; set; }
    }
}
