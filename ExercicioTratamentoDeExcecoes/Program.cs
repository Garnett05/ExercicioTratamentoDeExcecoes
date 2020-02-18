using System;
using System.Globalization;
using ExercicioTratamentoDeExcecoes.Entities;
using ExercicioTratamentoDeExcecoes.Entities.Exceptions;

namespace ExercicioTratamentoDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(withdrawValue);
                Console.WriteLine("New balance: " + acc.Balance, CultureInfo.InvariantCulture);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error! " + e.Message);
            }
        }
    }
}
