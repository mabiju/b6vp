namespace b_delegate_event;
#nullable disable

// step 1: define a delegate
public delegate void TrafficLightChangedHandler(string color);
public class TrafficLight
{
    // step 2: declare an event
    public event TrafficLightChangedHandler TrafficLightChanged;

    public void ChangeLight(string color)
    {
        // step 3: method that raises the event
        Console.WriteLine("The traffic light is " + color);
        TrafficLightChanged.Invoke(color);
    }
}
public class Car
{
    public void ReactToLight(string lightColor)
    {
        // step 4: event handling method
        if (lightColor == "Red")
        {
            Console.WriteLine("Car stops.");
        }
        else if (lightColor == "Green")
        {
            Console.WriteLine("Car starts moving.");
        }
    }
}
public class MainProgram
{
    public static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();
        Car car = new Car();
        // step 5: subscribe to the event
        light.TrafficLightChanged += car.ReactToLight;
        light.ChangeLight("Green");
        light.ChangeLight("Red");
    }
}
