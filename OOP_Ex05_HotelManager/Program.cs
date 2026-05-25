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

            Room[] myHotel = new Room[50];

            for (int i = 0; i < myHotel.Length; i++)
            {
                //guardar o número do quarto
                int currentRoomNumber = 300 + i;

                //guardar o valor do quarto
                double currentPrice = 0;

                if (i >= 0 && i <= 19) //(quarto 300 a 319)
                {
                    currentPrice = 65.99; //preço standart
                }
                else if (i >= 20 && i <= 39) //(quarto 320 a 339)
                {
                    currentPrice = 85.99; //preço executivo
                }
                else //(quarto 340 a 349)
                {
                    currentPrice = 105.99; //preço suite
                }

                //chamamos passando o numero do quarto e o valor
                myHotel[i] = new Room(currentRoomNumber, currentPrice);
            }

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
                            int searchRoomNumber1;
                            //perguntar o numero de quarto que deseja consultar
                            while (true)
                            {
                                Console.Write("Qual é o número do quarto que deseja consultar (300 a 349) ?: ");
                                string searchRoomString1 = Console.ReadLine();

                                if (int.TryParse(searchRoomString1, out searchRoomNumber1) && searchRoomNumber1 >= 300 && searchRoomNumber1 <= 349)
                                {
                                    //se digitou quarto 305, o index = a 305 - 300 = 5(posição no array)
                                    int index = searchRoomNumber1 - 300;

                                    //chama o metodo ShowStatus()
                                    myHotel[index].ShowStatus();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }
                            break;
                        case 2:
                            int searchRoomNumber2;
                            while (true)
                            {
                                Console.Write("\nDe qual quarto deseja fazer o check-in (300 a 349)?: ");
                                string searchRoomString2 = Console.ReadLine();

                                if (int.TryParse(searchRoomString2, out searchRoomNumber2) && searchRoomNumber2 >= 300 && searchRoomNumber2 <= 349)
                                {
                                    break; // Sai do loop se o número for válido
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }

                            int index2 = searchRoomNumber2 - 300;

                            if (myHotel[index2].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Já existe um check-in feito para o quarto {searchRoomNumber2}.\n" +
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
                            myHotel[index2].CheckIn(guestsInRoom[0], guestsInRoom[1]);
                            break;
                        case 3:
                            int searchRoomNumber3;
                            while (true)
                            {
                                Console.Write("\nDe qual quarto deseja fazer o check-out (300 a 349)?: ");
                                string searchRoomString3 = Console.ReadLine();

                                if (int.TryParse(searchRoomString3, out searchRoomNumber3) && searchRoomNumber3 >= 300 && searchRoomNumber3 <= 349)
                                {
                                    break; // Sai do loop se o número for válido
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }

                            int index3 = searchRoomNumber3 - 300;

                            if (!myHotel[index3].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {searchRoomNumber3}.\n" +
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
                            myHotel[index3].CheckOut(nightNumber, myCustomer); //Mandas as noites E o cartão do cliente para o quarto(classe)!
                            break;
                        case 4:
                            int searchRoomNumber4;
                            while (true)
                            {
                                Console.Write("\nDe qual quarto deseja levantar o resto do dinheiro (300 a 349)?: ");
                                string searchRoomString4 = Console.ReadLine();

                                if (int.TryParse(searchRoomString4, out searchRoomNumber4) && searchRoomNumber4 >= 300 && searchRoomNumber4 <= 349)
                                {
                                    break; // Sai do loop se o número for válido
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }

                            int index4 = searchRoomNumber4 - 300;

                            if (!myHotel[index4].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {searchRoomNumber4}.\n" +
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
                            int searchRoomNumber5;
                            while (true)
                            {
                                Console.Write("\nDe qual quarto deseja levantar o resto do dinheiro (300 a 349)?: ");
                                string searchRoomString5 = Console.ReadLine();

                                if (int.TryParse(searchRoomString5, out searchRoomNumber5) && searchRoomNumber5 >= 300 && searchRoomNumber5 <= 349)
                                {
                                    break; // Sai do loop se o número for válido
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }

                            int index5 = searchRoomNumber5 - 300;

                            if (myHotel[index5].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: O cliente ainda está no quarto {searchRoomNumber5} (Check-In ativo).\n" +
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
                            int searchRoomNumber6;
                            while (true)
                            {
                                Console.Write("\nDe qual quarto deseja ver os dados (300 a 349)?: ");
                                string searchRoomString6 = Console.ReadLine();

                                if (int.TryParse(searchRoomString6, out searchRoomNumber6) && searchRoomNumber6 >= 300 && searchRoomNumber6 <= 349)
                                {
                                    break; // Sai do loop se o número for válido
                                }
                                else
                                {
                                    Console.WriteLine($"\n[Erro]: Número de quarto incorreto. Tente novamente!\n");
                                }
                            }

                            int index6 = searchRoomNumber6 - 300;

                            if (!myHotel[index6].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o quarto {searchRoomNumber6}.\n" +
                                                  $"Então não pode ver os dados do cliente. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            myHotel[index6].ShowGuests();
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