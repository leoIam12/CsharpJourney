using System;

namespace OOP_Ex06_CentralParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking[] myParking = new Parking[10]; //lotação de 10 lugares

            for (int i = 0; i < myParking.Length; i++)
            {
                int fullParking = i + 1;
                myParking[i] = new Parking(fullParking);
            }
         
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----> Exercicio de Parque de Estacionamento Central <-----\n");

                Console.WriteLine("\n--- Menu Principal ---\n");

                string[] optionMenu = { "1 - Entrada", "2 - Saída", "3 - Ver Lugares", "4 - Fechar o Sistema" };
                foreach (string option in optionMenu)
                {
                    Console.WriteLine(option);
                }

                int optionNumber;
                Console.Write("\nOpção (1 a 4): ");
                string optionString = Console.ReadLine();

                if (int.TryParse(optionString, out optionNumber) && optionNumber >= 1 && optionNumber <= 4)
                {
                    switch (optionNumber)
                    {
                        case 1:
                            string licensePlate;
                            while (true)
                            {
                                Console.Write("\nInsira o número da matrícula do carro: "); //mas usa letra e número então (string)
                                licensePlate = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(licensePlate))
                                {
                                    Console.WriteLine("\n[Erro]: Espaço do número da matrícula vazio. Tente novamente!\n");
                                }
                                else
                                {
                                    break;
                                }
                            }

                            string carBrand;
                            while (true)
                            {
                                Console.Write("Insira a marca do carro: ");
                                carBrand = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(carBrand))
                                {
                                    Console.WriteLine("\n[Erro]: Espaço da marca do carro vazio. Tente novamente!\n");
                                }
                                else
                                {
                                    break;
                                }
                            }

                            bool foundPlace = false;

                            for (int i = 0; i < myParking.Length; i++) //percorrer todos os lugares
                            {
                                if (!myParking[i].GetIsOccupied()) //encontrou um lugar livre
                                {
                                    myParking[i].CheckIn(licensePlate, carBrand); //faz check-in nele
                                    foundPlace = true;
                                    break;
                                }
                            }

                            if(!foundPlace)
                            {
                                Console.WriteLine("\n[Desculpe]: O Parque de Estacionamento está completamente CHEIO!\n");
                            }


                            break;
                        case 2:
                            int numberPlace;
                            while (true)
                            {
                                Console.Write("\nInsira o número do lugar (1 a 10): "); 
                                string stringplace = Console.ReadLine();
                                if (int.TryParse(stringplace, out numberPlace) && numberPlace >= 1 && numberPlace <= 10)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Número do lugar incorreto. Tente novamente!\n");
                                }
                            }

                            int index2 = numberPlace - 1; //fazer isso para obter o indice (se for 1 é indice 0)

                            if (!myParking[index2].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o lugar {numberPlace}.\n" +
                                                  $"Então não pode fazer o check-out. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            double numberhoursPark;
                            while (true)
                            {
                                Console.Write("\nInsira quanto tempo o carro ficou no parque (em horas): ");
                                string stringhoursPark = Console.ReadLine();
                                if (double.TryParse(stringhoursPark, out numberhoursPark) && numberhoursPark > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Tempo de parque incorreto. Tente novamente!\n");
                                }
                            }

                            double totalPay = 2 + (numberhoursPark * 1.5);
                            Console.Write($"\nTotal a Pagar: {totalPay} Euros.\n");

                            myParking[index2].CheckOut(numberPlace);
                            break;
                        case 3:
                            int numberPlaceSearch;
                            while (true)
                            {
                                Console.Write("\nInsira o número do lugar para ver os detalhes (1 a 10): ");
                                string stringplaceSearch = Console.ReadLine();
                                if (int.TryParse(stringplaceSearch, out numberPlaceSearch) && numberPlaceSearch >= 1 && numberPlaceSearch <= 10)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Número do lugar incorreto. Tente novamente!\n");
                                }
                            }

                            int index3 = numberPlaceSearch - 1; //fazer isso para obter o indice (se for 1 é indice 0)

                            if (!myParking[index3].GetIsOccupied())
                            {
                                Console.WriteLine("\nEstado: Livre\n");
                                break; 
                            }
                            else
                            {
                                Console.WriteLine($"\nEstado: Ocupado."); 
                            }

                            myParking[index3].ShowStatus();
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