using System;
using System.Diagnostics.Metrics;

namespace Tutorial_Ex11_TemperatureAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Na ala de cuidados intensivos, monitorizamos a temperatura de um paciente crítico. <-----\n");

            int[] temperatureMeasurement = new int[4]; //medição de temperatura

            Console.WriteLine("---> Registo de Medição de Temperatura dos Pacientes em Estado Crítico <---\n");

            for (int i = 0; i < temperatureMeasurement.Length; i++)
            {
                Console.Write($"Insira a temperatura do Paciente ({i + 1}): ");
                temperatureMeasurement[i] = Convert.ToInt32(Console.ReadLine());

                if (temperatureMeasurement[i] < 35 ||  temperatureMeasurement[i] > 42)
                {
                    Console.WriteLine($"[Erro]: A Temperatura de {temperatureMeasurement[i]}ºC não está no intervalo aceite(35 a 42ºC).\n" +
                                  $"Tente novamente!\n");
                    i--;
                }
            }

            bool hasHighFever = false;

            foreach (int temp in temperatureMeasurement)
            {
                if (temp > 39)
                {
                    hasHighFever = true;
                    break;
                }
            }

            if (hasHighFever)
            {
                Console.WriteLine($"\nALERTA: Paciente registou febre alta durante o dia!");
            }

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}