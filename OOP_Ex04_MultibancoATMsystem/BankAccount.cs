using System;
using System.Reflection.Metadata;

namespace OOP_Ex04_MultibancoATMsystem
{
    class BankAccount
    {
        public string ownerName;
        private double balance; 


        public BankAccount(string name, double initialDeposit)
        {
            ownerName = name;
            balance = initialDeposit;
        }

        public void Deposit(double amount)
        {
            Console.WriteLine($"\nDéposito de {amount} efetuado com sucesso!\n");
            balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine($"\n[ERRO]: Saldo insuficiente para levantamento!\n");
            }
            else
            {
                Console.WriteLine($"\nLevantamento de {amount} efetuado com sucesso!\n");
                balance -= amount;
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Titular da Conta: {ownerName} | Saldo: {balance}£.");
        }
    }
}
