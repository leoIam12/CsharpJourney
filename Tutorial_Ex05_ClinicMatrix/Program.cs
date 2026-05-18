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

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}