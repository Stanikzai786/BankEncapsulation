namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much Money would you like to Deposit");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
        }
    }
}
