using System;

namespace Method_Ex05_AutomationOfVaccineStockAlerts
{
    class Program
    {
        static int SumVaccines(int totalSum, int quantity)
        {
            return totalSum += quantity;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----> Automatização de Alertas de Stock de Vacinas <-----\n");

            Console.WriteLine("-----> Login <-----\n");
            int count = 0;
            bool validation = false;

            while (count < 3)
            {
                Console.Write("Insira o seu Nome: ");
                string name = Console.ReadLine();

                Console.Write("Insira a sua palavra-passe: ");
                string password = Console.ReadLine();

                if (name.Trim() == "Leonel" && password == "AX79B")
                {
                    Console.WriteLine($"\nBem-Vindo, {name.Trim()}!\n");

                    string[] vaccineNames = new string[3];
                    int[] quantityStock = new int[3];
                    int sumV = 0;

                    for (int i = 0; i < vaccineNames.Length; i++)
                    {
                        Console.Write($"\nInsira o Nome da Vacina({i + 1}): ");
                        vaccineNames[i] = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(vaccineNames[i]))
                        {
                            Console.WriteLine($"\n[ERRO]: Espaço do nome da vacina vazio. Tente novamente!\n");
                            i--;
                            continue;
                        }

                        Console.Write($"\nInsira a quantidade em stock da Vacina ({vaccineNames[i]}): ");
                        quantityStock[i] = Convert.ToInt32(Console.ReadLine());

                        //imagina que só consigo ter 300 em stock 
                        if (quantityStock[i] < 0 || quantityStock[i] > 300)
                        {
                            Console.WriteLine($"\n[ERRO]: {quantityStock[i]} não está no intervalo(0 a 300). Tente novamente!\n");
                            i--;
                        }
                        else
                        {
                            sumV = SumVaccines(sumV, quantityStock[i]);

                            if (quantityStock[i] < 50)
                            {
                                Console.WriteLine($"\nAviso de Rutura: A vacina {vaccineNames[i]} tem apenas {quantityStock[i]} unidades.\n" +
                                                  $"Encomenda automática ativada.");
                            }
                        }
                    }

                    Console.WriteLine($"\nO total de vacinas no Edíficio é de {sumV} vacinas.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nNome ou palavra-passe incorreta. Tente novamente!\n");
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine("[ALERTA]: Esgotou o número de tentativas!\n");
                    }
                }
            }


            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}