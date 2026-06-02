using System;
using System.Runtime.ConstrainedExecution;

namespace OOP_Ex08_DriveFast_RentCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] myCar = new Car[5];

            myCar[0] = new Car("Fiat 500", 30);
            myCar[1] = new Car("Renault Clio", 40);
            myCar[2] = new Car("BMW Série 1", 75);
            myCar[3] = new Car("Mercedes Classe A", 90);
            myCar[4] = new Car("Porsche 911", 250);

            int opNumber;
            while(true)
            {
                Console.Clear();

                Console.WriteLine("\n--- Menu Principal ---\n");
                string[] MenuOption = { "1 - Alugar Carro", "2 - Ver Frota", "3 - Devolver e Faturar", "4 - Fechar Sistema" };
                foreach (string option in MenuOption)
                {
                    Console.WriteLine(option);
                }

                Console.Write("\nOpção (1 a 4): ");
                string opString = Console.ReadLine();

                if (int.TryParse(opString, out opNumber) && opNumber >= 1 && opNumber <= 4)
                {
                    switch (opNumber)
                    {
                        case 1:
                            Console.WriteLine("\n1 - Alugar Carro\n");

                            int x1 = 0;
                            foreach (Car car in myCar)
                            {
                                Console.WriteLine($"Carro {x1 + 1}: {car.brandCar}(Custa {car.priceDay}£ por dia)");
                                x1++;
                            }

                            int opCarNumber1;
                            while (true)
                            {
                                Console.Write("\nEscolha o carro que queres alugar(1 a 5): ");
                                string opCarString1 = Console.ReadLine();

                                if (int.TryParse(opCarString1, out opCarNumber1) && opCarNumber1 >= 1 && opCarNumber1 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[ERRO]: Este carro não existe. Tente novamente!\n");
                                }
                            }

                            int indexCar1 = opCarNumber1 - 1;
                            myCar[indexCar1].CheckIn();

                            break;
                        case 2:
                            Console.WriteLine("\n2 - Ver Frota\n");

                            int x2 = 0;
                            foreach (Car car in myCar)
                            {
                                Console.WriteLine($"Carro {x2 + 1}: {car.brandCar}(Custa {car.priceDay}£ por dia)");
                                x2++;
                            }

                            int opCarNumber2;
                            while (true)
                            {
                                Console.Write("\nEscolha o carro que queres ver o estado(1 a 5): ");
                                string opCarString2 = Console.ReadLine();

                                if (int.TryParse(opCarString2, out opCarNumber2) && opCarNumber2 >= 1 && opCarNumber2 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[ERRO]: Este carro não existe. Tente novamente!\n");
                                }
                            }

                            int indexCar2 = opCarNumber2 - 1;
                            myCar[indexCar2].ShowStatus();

                            break;
                        case 3:
                            Console.WriteLine("\n3 - Devolver e Faturar\n");

                            int x3 = 0;
                            foreach (Car car in myCar)
                            {
                                Console.WriteLine($"Carro {x3 + 1}: {car.brandCar}(Custa {car.priceDay}£ por dia)");
                                x3++;
                            }

                            int opCarNumber3;
                            while (true)
                            {
                                Console.Write("\nEscolha o carro que queres devolver(1 a 5): ");
                                string opCarString3 = Console.ReadLine();

                                if (int.TryParse(opCarString3, out opCarNumber3) && opCarNumber3 >= 1 && opCarNumber3 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[ERRO]: Este carro não existe. Tente novamente!\n");
                                }
                            }

                            int indexCar3 = opCarNumber3 - 1;

                            myCar[indexCar3].CheckOut();


                            break;
                        case 4:
                            Console.WriteLine("\n4 - Fechar Sistema\n");

                            Environment.Exit(0);
                            break;
                    }
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n[ERRO]: Opção Incorreta. Tente novamente!\n");
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
            }

        }
    }
}