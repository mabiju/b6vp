namespace h_linq_list;
#nullable disable

class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var pList = new List<Person>();

        pList.Add(
            new Person
            {
                Name = "Ram",
                Age = 30,
                Address = "Ktm"
            }
        );
        pList.Add(
            new Person
            {
                Name = "Hari",
                Age = 2,
                Address = "Lalitpur"
            }
        );
        pList.Add(
            new Person
            {
                Name = "Roshan",
                Age = 20,
                Address = "Banepa"
            }
        );
        pList.Add(
            new Person
            {
                Name = "Rajiv",
                Age = 21,
                Address = "Banepa"
            }
        );
        pList.Add(
            new Person
            {
                Name = "Rajkumar",
                Age = 19,
                Address = "Banepa"
            }
        );

        var q = from p in pList where p.Name.ToLower().Contains("r") && p.Age > 20 select p;
        foreach (var p in q)
        {
            Console.WriteLine("Name   : " + p.Name);
            Console.WriteLine("Address: " + p.Address);
            Console.WriteLine("Age    : " + p.Age);
            Console.WriteLine();
        }
        /* foreach (int n in a)
        {
           if (n > 5)
           {
               Console.WriteLine(n);
           }
        } */
    }
}
