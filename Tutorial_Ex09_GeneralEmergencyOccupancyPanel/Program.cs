using System;

namespace Tutorial_Ex09_GeneralEmergencyOccupancyPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Painel digital para a Urgência Geral com 2 Setores (Setor A e Setor B) <-----\n");

            int[,] sectors = new int[2, 2];

            string[] numStatus = { "Maca Livre", "Maca Ocupada"};

            int z = 0;
            Console.WriteLine($"-----> Estados da maca <-----");
            foreach (string status in numStatus)
            {
                Console.WriteLine($"Para {status} - digite ({z})");
                z++;
            }

            for (int row = 0; row < sectors.GetLength(0); row++)
            {
                for (int col = 0; col < sectors.GetLength(1); col++)
                {
                    Console.Write($"\nInsira o número do estado da maca ({col + 1}) do setor ({row + 1}):");
                    sectors[row,col] = Convert.ToInt32(Console.ReadLine());

                    if (sectors[row, col] < 0 || sectors[row, col] > 1)
                    {
                        Console.Write($"[Erro]: Número fora do intervalo entre (0 e 1). Tente novamente!");
                        col--;
                    }
                }
            }

            Console.WriteLine("\n\n--- PAINEL DE OCUPAÇÃO DA URGÊNCIA ---");
            Console.WriteLine("\t\tMaca 1\tMaca 2");
            Console.WriteLine("--------------------------------------");

            for (int row = 0; row < sectors.GetLength(0); row++)
            {
                // Escreve o nome do setor no início da linha
                // Truque simples: se row for 0 é Setor A, se for 1 é Setor B
                string sectorName = (row == 0) ? "Setor A" : "Setor B";
                Console.Write($"{sectorName}:\t");

                for (int col = 0; col < sectors.GetLength(1); col++)
                {
                    //Se for 1 escreve [Ocupada], se for 0 escreve [Livre]
                    if (sectors[row, col] == 1)
                    {
                        Console.Write("[Ocupada]\t");
                    }
                    else
                    {
                        Console.Write("[Livre]\t\t"); 
                    }
                }
                Console.WriteLine();
            }

                Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}