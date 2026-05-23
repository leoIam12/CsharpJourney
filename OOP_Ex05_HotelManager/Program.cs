using Microsoft.VisualBasic.FileIO;
using System;

namespace OOP_Ex05_HotelManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----> Contratado por um pequeno Boutique Hotel no centro da cidade. <-----\n\n");

            Console.WriteLine("--- Registo do Quarto ---\n");

            int roomNumber;
            while (true)
            {
                Console.Write("\nInsira o número do quarto: ");
                string roomString = Console.ReadLine();

                if (int.TryParse(roomString, out roomNumber) && roomNumber > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\n[Erro]: Não existe quarto com número {roomNumber}. Tente novamente!\n");
                }
            }

            double pricePerNightNumber;
            while (true)
            {
                Console.Write("\nInsira o preço do quarto por noite: ");
                string pricePerNightString = Console.ReadLine();

                if (double.TryParse(pricePerNightString, out pricePerNightNumber) && pricePerNightNumber > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\n[Erro]: Valor incorreto. Tente novamente!\n");
                }
            }
        }
    }
}