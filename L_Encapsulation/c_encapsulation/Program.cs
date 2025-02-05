namespace c_encapsulation;

public class BankAccount
{
    private decimal balance;

    // Constructor
    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    // Deposit Method
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Withdraw Method
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    // Check the Balance of Account
    public decimal GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create new Bank Account
        BankAccount myAccount = new BankAccount(1000);
        Console.WriteLine("Enter the amount you want to deposit:");
        int depoAmt = Convert.ToInt32(Console.ReadLine());
        myAccount.Deposit(depoAmt);
        Console.WriteLine("Balance after depositing: " + myAccount.GetBalance());

        Console.WriteLine("Enter the amount you want to withdraw:");
        int withdrawAmt = Convert.ToInt32(Console.ReadLine());
        myAccount.Withdraw(withdrawAmt);
        Console.WriteLine("Balance after withdrawing: " + myAccount.GetBalance());
    }
}

