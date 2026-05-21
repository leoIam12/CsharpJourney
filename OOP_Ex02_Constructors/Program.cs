using System;

namespace OOP_Ex02_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Estudo sobre Construtores <-----\n");

            string[] nameDoctor = new string[2];
            string[] specialtyDoctor = new string[2];


            for (int i = 0; i < nameDoctor.Length; i++)
            {
                Console.Write($"Insira o nome do/a Doutor/a({i+1}): ");
                nameDoctor[i] = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nameDoctor[i]))
                {
                    Console.WriteLine($"\n[ERRO]: Espaço do nome vazio. Tente novamente!\n");
                    i--;
                    continue;
                }

            }

            for (int x = 0; x < specialtyDoctor.Length; x++)
            {
                Console.Write($"\nInsira a especialidade do/a Doutor/a {nameDoctor[x]}: ");
                specialtyDoctor[x] = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(specialtyDoctor[x]))
                {
                    Console.WriteLine($"\n[ERRO]: Espaço da especialidade vazio. Tente novamente!\n");
                    x--;
                    continue;
                }
            }

            Doctor doc1 = new Doctor(nameDoctor[0], specialtyDoctor[0]);
            Doctor doc2 = new Doctor(nameDoctor[1], specialtyDoctor[1]);

            doc1.Introduce();
            doc2.Introduce();

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}