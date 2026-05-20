using System;

namespace Method_Ex03_MedicalSearch
{
    class Program
    {
        static void SearchPatient(int id)
        {
            Console.WriteLine($"\nA pesquisar na base de dados pelo Paciente com ID Númerico: {id}.\n");
        }

        static void SearchPatient(string name)
        {
            Console.WriteLine($"\nA pesquisar na base de dados pelo Paciente com Nome: {name}.\n");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("-----> Pesquisar Paciente por id ou nome <-----\n");

            bool validationNum = false;
            while (!validationNum)
            {
                Console.Write("Como deseja procurar o Paciente?\n\n" +
                              "1 - Por ID\n" +
                              "2 - Por Nome\n" +
                              "\nResposta: ");

                int chooseNum = Convert.ToInt32(Console.ReadLine());

                if (chooseNum == 1)
                {
                    Console.Write("Insira o ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    SearchPatient(id);
                    validationNum = true;
                }
                else if (chooseNum == 2)
                {
                    Console.Write("Insira o Nome: ");
                    string name = Console.ReadLine();
                    SearchPatient(name);
                    validationNum = true;
                }
                else
                {
                    Console.WriteLine($"[Erro]: O Número ({chooseNum}) não está no intervalo(1 a 2).\n" +
                                                $"Tente novamente!\n");
                }
            }

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}