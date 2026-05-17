using System;

namespace Tutorial_Ex_03_UrgencyCHart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> O diretor do hospital quer um gráfico visual de barras para ver a ocupação das macas. <-----");

            Console.Write("Insira o número de Setores: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o número de Macas por Setor: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            // '*' table
            for (int row = 1; row <= rows; row++)
            {
                for(int col = 1; col <= cols; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}