using System;
using Exercicio01.Entities.Exception;
using Exercicio01.Entities;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number of account: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder name: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine("");

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amount);

            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error in process: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro in process: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in process: " + e.Message);
            }
        }
    }
}
