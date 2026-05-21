using System;

namespace Method_Ex04_RapidTriageSystemForMornings
{
    class Program
    {
        static double CalculateAverage(int totalSum, double quantity)
        {
            double average = totalSum / quantity;
            return average;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----> Necessidade de um Sistema de Triagem Rápida para as Manhãs <-----\n");

            string[] patientName = new string[5];
            int[] levelPain = new int[5];
            int sumPain = 0;
            double averagePain = 0;

            for (int i = 0; i < patientName.Length; i++)
            {
                Console.Write($"Insira o nome do Paciente ({i+1}): ");
                patientName[i] = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(patientName[i]))
                {
                    Console.WriteLine("\n[ERRO]: Espaço do nome vazio. Tente novamente!\n");
                    i--;
                    continue; //para recomeçar o ciclo novamente antes de colocar a dor
                }

                Console.Write($"Insira o nível de Dor do Paciente {patientName[i]} - (0 a 10): ");
                levelPain[i] = Convert.ToInt32(Console.ReadLine());

                if (levelPain[i] < 0 || levelPain[i] > 10)
                {
                    Console.WriteLine($"\n[ERRO]: Nível de Dor do Paciente {patientName[i]} inválido. Tente novamente!\n");
                    i--;
                }
                else
                {
                    sumPain += levelPain[i];

                    if (levelPain[i] >= 8)
                    {
                        Console.WriteLine($"\n[ALERTA VERMELHO]: Encaminhar {patientName[i]} imediatamente para a sala de reanimação!\n");
                    }
                }
            }

            averagePain = CalculateAverage(sumPain, levelPain.Length);

            Console.WriteLine("\n---> Lista dos Pacientes <---\n");
            int x = 0;
            foreach (string name in patientName)
            {
                Console.WriteLine($"{x+1} - {name}");
                x++;
            }

            Console.WriteLine($"\nA média de dores dos pacientes nessa Manhã é: {Math.Round(averagePain, 2)}\n");

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}