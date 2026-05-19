using System;

namespace Tutorial_Ex08_MultifunctionWaitingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> O programa não aceite nomes vazios ou cheios de espaços. <-----\n");

            string[] patientNames = new string[3];
            int totalCharacters = 0;

            for (int i = 0; i < patientNames.Length; i++)
            {
                Console.Write($"Insira o Nome do Paciente ({i + 1}): ");
                patientNames[i] = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(patientNames[i]))
                {
                    Console.WriteLine("[Erro]: Espaço do nome vazio. Tente novamente!\n");
                    i--;
                }
            }

            Console.WriteLine("\n-----> Lista de Pacientes <-----");

            int num = 0;
            foreach (string patientName in patientNames)
            {
                Console.WriteLine($"{num + 1} - {patientName}");

                totalCharacters = totalCharacters + patientName.Trim().Length;
                num++;
            }

            Console.WriteLine($"Total de letras ao todo no sistema: {totalCharacters}");

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}