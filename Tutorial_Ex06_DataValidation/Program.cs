using System;

namespace Tutorial_Ex06_DataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este exercício vai treinar a tua capacidade de blindar...\n " +
                              "-----> ...O sistema contra utilizadores distraídos que digitam dados impossíveis. <-----");


            while (true)
            {
                Console.Write("Insira a idade do Paciente: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Idade inválida! Tente novamente.");
                    continue; //para obrigar o ciclo a recomeçar do topo imediatamente, sem avançar.
                }
                else
                {
                    //Se a idade for válida, quebra o ciclo
                    break;
                }
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}