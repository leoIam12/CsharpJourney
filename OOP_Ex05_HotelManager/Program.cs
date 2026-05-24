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
            CustomerAccount myCustomer = new CustomerAccount();
            Guest[] guestsInRoom = new Guest[2];

            while (true)
            {
                Console.Clear();

                string[] optionMenu = {"1 - Ver Estado do Quarto", "2 - Fazer Check-In", "3 - Fazer Check-Out", 
                                       "4 - Depositar o dinheiro do Cliente", "5 - Levantar o resto do dinheiro do Cliente",
                                       "6 - Mostrar os dados do Cliente", "7 - Fechar o Sistema"};

                Console.WriteLine("--- Menu Principal ---\n");
                foreach (string opt in optionMenu)
                {
                    Console.WriteLine(opt);
                }

                int optionNumber;
                Console.Write("\nOpcão: ");
                string optionString = Console.ReadLine();

                if (int.TryParse(optionString, out optionNumber) && optionNumber >= 1 && optionNumber <= 7)
                {
                    switch (optionNumber)
                    {
                        case 1:
                            myRoom.ShowStatus();
                            break;
                        case 2:
                            if (myRoom.GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Já existe um check-in feito para o quarto {roomNumber}.\n" +
                                                  $"Então não pode fazer o check-in novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            int personNumber;
                            //perguntar a quantidade de pessoas
                            while (true)
                            {
                                Console.Write("\nO check-in é para quantas pessoas (1 ou 2): ");
                                string personString = Console.ReadLine();

                                if (int.TryParse(personString, out personNumber) && personNumber >= 1 && personNumber <= 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de pessoas incorreto. Tente novamente!\n");
                                }
                            }

                            // Limpar o array por segurança antes de começar
                            guestsInRoom[0] = null;
                            guestsInRoom[1] = null;

                            //recolher dados
                            for (int i = 0; i < personNumber; i++)
                            {
                                string guestName;
                                while (true)
                                {
                                    if (i == 0)
                                    {
                                        Console.Write($"\nInsira o Nome do Hóspede Principal/Titular: ");
                                    }
                                    else
                                    {
                                        Console.Write($"\nInsira o Nome do Acompanhante: ");
                                    }

                                    guestName = Console.ReadLine();

                                    if (!string.IsNullOrWhiteSpace(guestName))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n[Erro]: Nome incorreto. Tente novamente!\n");
                                    }
                                }

                                int guestAgeNumber;
                                while (true)
                                {

                                    if (i == 0)
                                    {
                                        Console.Write($"\nInsira a Idade do Hóspede Principal/Titular: ");
                                    }
                                    else
                                    {
                                        Console.Write($"\nInsira a Idade do Acompanhante: ");
                                    }
                                    string guestAgeString = Console.ReadLine();

                                    if (int.TryParse(guestAgeString, out guestAgeNumber) && guestAgeNumber > 0 && guestAgeNumber < 120)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n[Erro]: Idade incorreta. Tente novamente!\n");
                                    }
                                }

                                int guestIDNumber;
                                while (true)
                                {
                                    if (i == 0)
                                    {
                                        Console.Write($"\nInsira o BI do Hóspede Principal/Titular: ");
                                    }
                                    else
                                    {
                                        Console.Write($"\nInsira o BI do Acompanhante: ");
                                    }
                                    string guestIDString = Console.ReadLine();

                                    if (int.TryParse(guestIDString, out guestIDNumber) && guestIDNumber > 0)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\n[Erro]: BI incorreto. Tente novamente!\n");
                                    }
                                }

                                //Pegar no Nome, Idade e BI, criamos o Objeto Guest, e guardar na posição [i] do array
                                guestsInRoom[i] = new Guest(guestName, guestAgeNumber, guestIDNumber);
                            }

                            //Mando os objetos reais para o quarto
                            //O guestsInRoom[1] pode ir como null se a pessoa escolheu apenas 1 hóspede. O Quarto sabe lidar com isso
                            myRoom.CheckIn(guestsInRoom[0], guestsInRoom[1]);
                            break;
                        case 3:
                            if (!myRoom.GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {roomNumber}.\n" +
                                                  $"Então não pode fazer o check-out. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

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
                            myRoom.CheckOut(nightNumber, myCustomer); //Mandas as noites E o cartão do cliente para o quarto(classe)!
                            break;
                        case 4:
                            if (!myRoom.GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {roomNumber}.\n" +
                                                  $"Então não pode fazer o depósito. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            double depositNumber;
                            while (true)
                            {
                                Console.Write("\nQuanto o cliente quer depositar: ");
                                string depositString = Console.ReadLine();

                                if (double.TryParse(depositString, out depositNumber) && depositNumber > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Valor do depósito incorreto. Tente novamente!\n");
                                }
                            }
                            myCustomer.Deposit(depositNumber);
                            break;
                        case 5:
                            if (myRoom.GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: O cliente ainda está no quarto {roomNumber} (Check-In ativo).\n" +
                                                  $"Não pode levantar o dinheiro antes de fazer o Check-Out e pagar a conta!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            string moneyLeftString;
                            while (true)
                            {
                                Console.Write("\nDeseja retirar todo o dinheiro do Cliente?(Sim ou Não): ");
                                moneyLeftString = Console.ReadLine().Trim().ToLower();

                                if (moneyLeftString == "sim" || moneyLeftString == "não" || moneyLeftString == "nao")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Resposta errada. Digite apenas 'Sim' ou 'Não'. Tente novamente!");
                                }
                            }
                            myCustomer.MoneyLeft(moneyLeftString);
                            break;
                        case 6:
                            if (!myRoom.GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {roomNumber}.\n" +
                                                  $"Então não pode ver os dados do cliente. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            myRoom.ShowGuests();
                            myCustomer.ShowCustomerData();
                            break;
                        case 7:
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