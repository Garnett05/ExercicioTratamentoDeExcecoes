using System;
using System.Collections.Generic;
using System.Text;
using ExercicioTratamentoDeExcecoes.Entities.Exceptions;

namespace ExercicioTratamentoDeExcecoes.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance <= 0.0)
            {
                throw new DomainException ("WARNING: Not enought balance for the withdraw");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("WARNING: The amount especify exceeds withdraw limit!");
            }
            if (amount > Balance)
            {
                throw new DomainException("WARNING: The amount especify is higher then the account balance");
            }
            Balance -= amount;
        }
    }
}
