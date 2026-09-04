namespace f_constructor_overloading_diff_no_of_paras;

class Nums
{
    int m, n;
    int p, q, r;
    public Nums(int a, int b)
    {
        m = a;
        n = b;
    }
    public Nums(int x, int y, int z)
    {
        p = x;
        q = y;
        r = z;
    }

    public void displaySum()
    {
        Console.WriteLine("The Sum = " + (m + n));
    }
    public void displayProduct()
    {
        Console.WriteLine("The Product = " + (p * q * r));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums obj1 = new Nums(12, 34);
        Nums obj2 = new Nums(2, 3, 4);
        obj1.displaySum();
        obj2.displayProduct();
    }
}

