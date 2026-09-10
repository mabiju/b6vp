namespace d_events;
#nullable disable

class NameChangedEventArgs : EventArgs
{
    public string OldName { get; private set; }
    public string NewName { get; private set; }

    public NameChangedEventArgs(string oldName, string newName)
    {
        OldName = oldName;
        NewName = newName;
    }
}
class Person
{
    public event EventHandler<NameChangedEventArgs> Changed;

    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            string oldName = name;
            string newName = value;

            name = value;
            if (Changed != null)
            {
                Changed(this, new NameChangedEventArgs(oldName, newName));
            }
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Changed += Person_Changed;
        p.Name = "Ram";
        p.Name = "Hari";
        p.Name = "Shyam";
        Console.ReadLine();
    }

    private static void Person_Changed(object sender, NameChangedEventArgs e)
    {
        Console.WriteLine("Person has changed from {0} to {1}", e.OldName, e.NewName);
    }
}
