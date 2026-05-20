using System;

namespace Tutorial_Ex12_AmbulanceFuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Gerimos a frota de 3 ambulâncias do nosso posto médico. <-----\n");

            double[] qFuel = new double[3];
            double sumFuel = 0;

            for (int i = 0; i < qFuel.Length; i++)
            {
                Console.Write($"Insira a quantidade(litros) da {i + 1}º Ambulância: ");
                qFuel[i] = Convert.ToDouble(Console.ReadLine());
  
                if (qFuel[i] < 0 || qFuel[i] > 60)
                {
                    Console.WriteLine($"[Erro]: A Quantidade de {qFuel[i]} Litros inserida na {i + 1}º Ambulância não está no intervalo(0 a 60 litros).\n" +
                                        $"Tente novamente!\n");
                    i--;
                }
                else
                {
                    sumFuel += qFuel[i];
                }
                
            }
            bool hasLowFuel = false;

            foreach (double fuel in qFuel)
            {
                if (fuel < 10)
                {
                    hasLowFuel = true;
                    break;
                }
            }

            if (hasLowFuel)
            {
                Console.WriteLine("\n[Aviso]: Ambulância em Reserva!");
            }

            Console.WriteLine($"\nO total de combustível que temos disponível na frota inteira é de {sumFuel} Litros.");

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
} 