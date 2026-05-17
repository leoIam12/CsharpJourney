using System;

namespace Tutorial_Ex01_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----> Gerir o tempo de espera de 3 pacientes no Hospital de Lembá. <-----");

            string[] patientNames = new string[3];
            int[] waitingTimes = new int[3];

            Console.WriteLine("Insira os Nomes dos Pacientes: ");

            for (int i = 0; i < patientNames.Length; i++)
            {
                Console.Write(i+1 + " - ");
                patientNames[i] = Console.ReadLine();
            }

            int maxTime = 0;
            int minTime = 0;
            Console.WriteLine("Insira quanto tempo(minuto/s) os Pacientes estão a espera: ");

            for (int i = 0; i < waitingTimes.Length; i++)
            {
                Console.Write($"O paciente {patientNames[i]} está esperando á: ");
                waitingTimes[i] = Convert.ToInt32(Console.ReadLine());


                //know what the longest(maior) time is and know what the shortest(menor) time is
                if (i == 0)
                {
                    maxTime = waitingTimes[i];
                    minTime = waitingTimes[i];
                }
                else
                {
                    if (waitingTimes[i] > maxTime)
                    {
                        maxTime = waitingTimes[i];
                    }

                    if (waitingTimes[i] < minTime)
                    {
                        minTime = waitingTimes[i];
                    }
                }   
            }

            Console.WriteLine($"O tempo máximo de espera é: {maxTime} min.\nO tempo mínimo de espera é: {minTime} min.");


            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();

        }
    }
}