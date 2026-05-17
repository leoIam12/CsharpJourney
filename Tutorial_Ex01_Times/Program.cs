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

            Console.WriteLine("Insira quanto tempo(minuto/s) os Pacientes estão a espera: ");

            for (int i = 0; i < waitingTimes.Length; i++)
            {
                Console.Write($"O paciente {patientNames[i]} está esperando á: ");
                patientNames[i] = Console.ReadLine();
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();

        }
    }
}