namespace g_linq_list;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        IList<Car> CarList = new List<Car>()
        {
            new Car()
            {
                CarID = 1,
                CarName = "Honda",
                CarCost = 55000,
                LotNo = 5
            },
            new Car()
            {
                CarID = 2,
                CarName = "Bugati Veron",
                CarCost = 45000,
                LotNo = 1
            },
            new Car()
            {
                CarID = 3,
                CarName = "Ferrari",
                CarCost = 45896,
                LotNo = 2
            },
            new Car()
            {
                CarID = 4,
                CarName = "Mercedes",
                CarCost = 120000
            }
        };
        var CarNames = CarList
            .Where(c => c.CarCost > 40000)
            .Select(c => c)
            .Where(cr => cr.LotNo > 1)
            .Select(c => c.CarName);

        foreach (var name in CarNames)
        {
            Console.WriteLine(name);
        }
    }
}
public class Car
{
    public int CarID { get; set; }
    public string CarName { get; set; }
    public int CarCost { get; set; }
    public int LotNo { get; set; }
}

