namespace BankEncapsulation
{
    public class Program {
        public static void Main(string[] Args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine($" How much $ do you want to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine()!);

            ba.deposit(amountToDeposit);

            double userBalance = ba.GetBalance();
            Console.WriteLine($" Your current balance is {userBalance, 0:c}");

        }






    }
    






}
