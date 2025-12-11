namespace c_events;

#nullable disable
delegate void OrderEventHandler();
class Order
{
    // declaring an event
    public event OrderEventHandler OnCreated;

    public void Create()
    {
        Console.WriteLine("Order created");

        // raising an event
        if (OnCreated != null)
        {
            OnCreated();
        }
    }
}
class Email
{
    public static void Send()
    {
        Console.WriteLine($"Send an email");
    }
}
class SMS
{
    public static void Send()
    {
        Console.WriteLine($"Send an SMS");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // subscribing to an event
        var order = new Order();
        order.OnCreated += Email.Send;
        order.OnCreated += SMS.Send;
        order.Create();
    }
}