using System;

namespace OOP_Ex01_ClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Estudo sobre Classes e Membros <-----\n");

            Patient patient = new Patient();

            while (true)
            {
                Console.Write("Insira o seu Nome: ");
                patient.name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(patient.name))
                {
                    Console.WriteLine($"\n[ERRO]: Espaço do nome vazio. Tente novamente!\n");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Insira a sua Idade: ");
                string ageInput = Console.ReadLine();

                if (int.TryParse(ageInput, out patient.age))
                {
                    if (patient.age < 0 || patient.age > 120)
                    {
                        Console.WriteLine($"\n[ERRO]: Esta Idade não está no intervalo permitido(0 a 120 anos). Tente novamente!\n");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\n[ERRO]: Por favor, digite apenas números inteiros. Tente novamente!\n");
                }
              
            }


                patient.ShowInfo();

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}