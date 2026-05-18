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

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}