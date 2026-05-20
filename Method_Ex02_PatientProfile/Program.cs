using System;

namespace Method_Ex02_PatientProfile
{
    class Program
    {
        static void RegisterPatient(string name, int age, string country = "São Tomé e Príncipe")
        {
            Console.WriteLine("---> Dados do Paciente <---\n");
            Console.WriteLine($"Nome: {name} \nIdade: {age} anos \nPaís de Nacionalidade: {country}\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-----> Registar Paciente com Metodo e Parametro(não retorna) <-----\n");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Idade: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("País: ");
            string country = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(country))
            {
                //Se a caixa de texto do País estiver vazia, mostra o País por defeito no Metodo
                Console.Write("\n-- Teste 1 --\n");
                RegisterPatient(name, age);
            }
            else
            {
                //Se a caixa de texto do País não estiver vazia, mostra o País colocado na caixa
                Console.Write("\n-- Teste 2 --\n");
                RegisterPatient(name, age, country);
            }

            Console.Write("-- Chamada 1 --\n");
            RegisterPatient("Leonel Fernandes", 22);

            Console.Write("-- Chamada 2 --\n");
            RegisterPatient(age: 22, country: "Portugal", name: "Leonel Fernandes");


            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}