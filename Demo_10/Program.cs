namespace Demo_10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount(100m);
            decimal[] amounts = { 50m, 80m, 0m, -20m, 50m };

            Console.WriteLine($"Начална наличност: {account.Balance}");

            foreach (decimal amount in amounts)
            {
                Console.WriteLine($"Опит за теглене: {amount}");

                try
                {
                    account.Withdraw(amount);
                    // Ако Withdraw хвърли изключение, този ред се пропуска.
                    Console.WriteLine("Успешно теглене.");
                }
                catch (InsufficientFundsException e)
                {
                    Console.WriteLine($"Недостатъчна наличност: {e.Message}");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Невалидна сума: въведете положителна стойност.");
                }
                finally
                {
                    Console.WriteLine($"Текуща наличност: {account.Balance}");
                    Console.WriteLine();
                }
            }
        }
    }
}
