namespace a_delegate_event;


public delegate string MyDel(string str);
class EventPro
{
    event MyDel MyEvent;

    public EventPro()
    {
        this.MyEvent += new MyDel(this.DisplayMessage);
    }

    public string DisplayMessage(string username)
    {
        return "Hello " + username;
    }
    static void Main(string[] args)
    {
        EventPro obj = new EventPro();
        string result = obj.MyEvent("Sanothimi Campus");
        Console.WriteLine(result);
    }
}

