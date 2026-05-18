using System;
using System.IO.Pipes;

namespace Tutorial_Ex04_StockForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos gerir o stock da farmácia do Hospital de Trindade usando o ciclo foreach\n " +
                              "-----> (Que serve para varrer um array do início ao fim de forma mais simples e limpa). <-----");

            int[] medicationStocks = new int[5];

            for (int i = 0; i < medicationStocks.Length; i++)
            {
                Console.Write($"Quantidade em Stock do Medicamento {i+1}: ");
                medicationStocks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int totalStock = 0;
            int lowStockCount = 0;

            foreach (int stock in medicationStocks)
            {
                //to know the quantity of products in stock
                if (stock < 10)
                {
                    lowStockCount++;
                }

                totalStock = totalStock + stock;
            }

            Console.WriteLine($"O total de caixas de medicamentos em stock é: {totalStock}.");
            Console.WriteLine($"~Medicamentos em stock crítico(menos que 10): {lowStockCount}.");

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}