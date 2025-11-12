namespace d_abstract_netflixplan;

public abstract class NetflixPlan
{
    protected double rate;
    public abstract void getUnit();
    public void calcAmt(int units)
    {
        Console.WriteLine("Total amount for {0} units = {1}", units, units * rate);
    }
}

class SilverUserPlan : NetflixPlan
{
    public override void getUnit()
    {
        rate = 2.0;
    }
}
class GoldUserPlan : NetflixPlan
{
    public override void getUnit()
    {
        rate = 2.5;
    }
}
class DiamondUserPlan : NetflixPlan
{
    public override void getUnit()
    {
        rate = 5.0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        NetflixPlan user;
        user = new SilverUserPlan();
        user.getUnit();
        user.calcAmt(100);
        user = new GoldUserPlan();
        user.getUnit();
        user.calcAmt(27);
        user = new DiamondUserPlan();
        user.getUnit();
        user.calcAmt(13);
    }
}
