namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("BG123456");

            acc.Deposit(1000);
            acc.Withdraw(250);

            Console.WriteLine(acc.GetInfo());
        }
    }
}
