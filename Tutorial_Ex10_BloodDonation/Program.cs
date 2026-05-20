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
            }

            Console.WriteLine("\n---> Lista dos Doadores de Sangue <---");

            int z = 0;
            foreach (string name in nameBloodDonors)
            {
                Console.WriteLine($"{z + 1} - {name}");
                z++;
            }

            Console.WriteLine("\n---> Registo da Idade do Doador de Sangue <---\n");

            for (int i = 0; i < ageBloodDonors.Length; i++)
            {
                Console.Write($"Insira a idade do Doador de Sangue ({nameBloodDonors[i]}): ");
                ageBloodDonors[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}