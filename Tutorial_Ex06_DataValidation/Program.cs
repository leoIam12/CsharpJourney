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

            //screening color(cor da triagem)
            string[] screeningColor = { "Vermelho", "Amarelo", "Verde" };

            bool validColor = false;

            while (!validColor)
            {
                Console.WriteLine("\n----- Menu de Triagem -----");
                int i = 0;
                foreach (string color in screeningColor)
                {
                    Console.WriteLine($"{i + 1} - {color}");
                    i++;
                }

                Console.Write("Indica o número da cor da triagem: ");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Atendimento imediato!");
                        validColor = true;
                        break;
                    case 2:
                        Console.WriteLine("Esperar 20min!");
                        validColor = true;
                        break;
                    case 3:
                        Console.WriteLine("Esperar 40min!");
                        validColor = true;
                        break;
                    default:
                        Console.WriteLine("Não existe essa cor. Tente novamente!");
                        break;
                }
            }

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}