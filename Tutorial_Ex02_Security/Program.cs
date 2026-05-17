using System;
using static System.Net.Mime.MediaTypeNames;

namespace Tutorial_Ex_02_Security
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O portal do \"STP-Health\" precisa de um bloqueio de segurança:  \n" +
                              "-----> O utilizador só tem 3 tentativas para acertar a palavra-passe. <-----");

            string correctPassword = "STP2026";

            //number of attempts
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Insira a sua palavra-passe: ");
                string password = Console.ReadLine();

                if (password.Trim().ToUpper() == correctPassword)
                {
                    Console.WriteLine("Acesso Concedido!");
                    break;
                }
                else
                {
                    attempts++;
                    if (attempts == 3)
                    {
                        Console.WriteLine("Conta Bloqueada de imediato!");
                    }
                }
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}