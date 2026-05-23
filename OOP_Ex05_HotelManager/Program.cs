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

            Room myRoom = new Room(roomNumber, pricePerNightNumber);

            while (true)
            {
                Console.Clear();

                string[] optionMenu = {"1 - Ver Estado do Quarto", "2 - Fazer Check-In", "3 - Fazer Check-Out", "4 - Fechar o Sistema"};

                Console.WriteLine("--- Menu Principal ---\n");
                foreach (string opt in optionMenu)
                {
                    Console.WriteLine(opt);
                }

                int optionNumber;
                Console.Write("\nOpcão: ");
                string optionString = Console.ReadLine();

                if (int.TryParse(optionString, out optionNumber) && optionNumber >= 1 && optionNumber <= 4)
                {
                    switch (optionNumber)
                    {
                        case 1:
                            myRoom.ShowStatus();
                            break;
                        case 2:
                            myRoom.CheckIn();
                            break;
                        case 3:
                            int nightNumber;
                            while (true)
                            {
                                Console.Write("\nQuantas noites o cliente ficou: ");
                                string nightString = Console.ReadLine();

                                if (int.TryParse(nightString, out nightNumber) && nightNumber > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de noites incorreto. Tente novamente!\n");
                                }
                            }
                            myRoom.CheckOut(nightNumber);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"\n[Erro]: Opção Incorreta. Tente novamente!\n");
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
                
            }
        }
    }
}