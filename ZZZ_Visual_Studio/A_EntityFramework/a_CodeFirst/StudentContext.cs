using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_CodeFirst
{
    internal class StudentContext : DbContext
    {
        public StudentContext() : base()
        {
            Database.SetInitializer<StudentContext>(new CreateDatabaseIfNotExists<StudentContext>());
        }
        public DbSet<Student> Students { get; set; }
    }
}
