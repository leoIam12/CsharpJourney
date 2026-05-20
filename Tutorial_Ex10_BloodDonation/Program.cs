using System;
using System.Xml.Linq;

namespace Tutorial_Ex10_BloodDonation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Aplicação para a nossa campanha de recolha de sangue no hospital. <-----\n");

            string[] nameBloodDonors = new string[3];
            int[] ageBloodDonors = new int[3];

            Console.WriteLine("---> Registo do Nome do Doador de Sangue <---\n");

            for (int i = 0; i < nameBloodDonors.Length; i++)
            {
                Console.Write($"Insira o nome do Doador de Sangue ({i + 1}): ");
                nameBloodDonors[i] = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameBloodDonors[i]))
                {
                    Console.WriteLine("[Erro]: Espaço do nome vazio. Tente novamente!\n");
                    i--;
                }
            }

            Console.WriteLine("\n---> Lista dos Doadores de Sangue <---");

            int z = 0;
            foreach (string name in nameBloodDonors)
            {
                Console.WriteLine($"{z + 1} - {name}");
                z++;
            }

            Console.WriteLine("\n---> Registo da Idade do Doador de Sangue <---\n");
            int sumAge = 0;
            double averageAge = 0.0;  //Calculate average(média) age

            for (int i = 0; i < ageBloodDonors.Length; i++)
            {
                Console.Write($"Insira a idade do Doador de Sangue ({nameBloodDonors[i]}): ");
                ageBloodDonors[i] = Convert.ToInt32(Console.ReadLine());

                if (ageBloodDonors[i] <  18 || ageBloodDonors[i] > 65)
                {
                    Console.WriteLine($"[Erro]: A idade do Doador de Sangue {nameBloodDonors[i]} não está no intervalo permitido(18 a 65 anos).\n" +
                                      $"Tente novamente!\n");
                    i--;
                }
                else
                {
                    sumAge += ageBloodDonors[i];
                }
            }

            averageAge = (double)sumAge / ageBloodDonors.Length;

            Console.WriteLine($"\nA média da idade dos Doadores de sangue é de {Math.Round(averageAge)} anos.");

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}