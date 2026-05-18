using System;

namespace Tutorial_Ex05_ClinicMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Clínica com 2 salas e cada sala tem 3 camas, com linhas e colunas Matriz(Array - 2D). <-----");

            //clinic bedrooms - store patients' age
            int[,] clinicBeds = new int[2,3];

            //row - rooms(salas) | col = beds(camas)
            //GetLength(0) -> saber a quantidade do array[2]
            //GetLength(1) -> saber a quantidade do array[3]

            for (int row = 0; row < clinicBeds.GetLength(0); row++)
            {
                for (int col = 0; col < clinicBeds.GetLength(1); col++)
                {
                    Console.Write($"Digite a idade do paciente da Sala {row + 1} - Cama {col + 1}: ");
                    clinicBeds[row, col] = Convert.ToInt32(Console.ReadLine());   
                }
            }

            // 1. Imprime o cabeçalho das colunas (Camas) ANTES dos ciclos
            Console.WriteLine("\tCama 1\tCama 2\tCama 3");
            Console.WriteLine("-------------------------------");

            for (int row = 0; row < clinicBeds.GetLength(0); ++row)
            {
                // 2. Imprime o nome da sala no início de cada linha, antes das idades
                Console.Write($"Sala {row + 1}|\t");
                for (int col = 0; col < clinicBeds.GetLength(1); ++col)
                {
                    //usar \t para organizar com espaços como uma tabela
                    Console.Write($"{clinicBeds[row, col]}\t");
                }
                Console.WriteLine();
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}