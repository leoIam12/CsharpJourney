using System;

namespace OOP_Ex04_MultibancoATMsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Foste contratado por um banco para criar o software das caixas automáticas(Multibanco) <-----\n");

            string name;
            double deposit;

            while (true)
            {
                Console.Write("\nInsira o seu Nome: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"\n[ERRO]: Espaço do nome vazio. Tente novamente!");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("\nInsira o seu Depósito Inicial: ");
                string depositString = Console.ReadLine();

                if (double.TryParse(depositString, out deposit) && deposit >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\n[ERRO]: Espaço do nome vazio. Tente novamente!");
                }
            }

            BankAccount myAccount = new BankAccount(name, deposit);


            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}