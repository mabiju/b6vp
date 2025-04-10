using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_console_ef_modelfirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentModelContainer())
            {
                // creating and storing new Tea Records
                Console.WriteLine("Enter Student Roll Number:");
                var s_roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name:");
                var s_name = Console.ReadLine();

                var student = new Student
                {
                    StuRoll = s_roll,
                    StudentName = s_name,
                };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from t in db.Students
                            orderby t.StudentName
                            select t;
                Console.WriteLine("Student records in the database : ");

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }
                Console.WriteLine("Press any key to exit......");
                Console.ReadKey();
            }
        }
    }
}
