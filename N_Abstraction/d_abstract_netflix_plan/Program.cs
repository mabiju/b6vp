namespace d_abstract_netflix_plan;

public abstract class NetfilxPlan
{
    protected double rate;
    public abstract void getRate();
    public void calcAmt(int units)
    {
        Console.WriteLine("The amount for {0} units is = {1}", units, units * rate);
    }
}

class GoldUserPlan : NetfilxPlan
{
    public override void getRate()
    {
        rate = 2.5;
    }
}
class DiamondUserPlan : NetfilxPlan
{
    public override void getRate()
    {
        rate = 5.0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        NetfilxPlan user;
        user = new GoldUserPlan();
        Console.WriteLine("Gold User Payment Details");
        Console.WriteLine(".........................");
        user.getRate();
        user.calcAmt(100);
        user = new DiamondUserPlan();
        Console.WriteLine("\n\nDiamond User Payment Details");
        Console.WriteLine(".........................");
        user.getRate();
        user.calcAmt(100);
    }
}
