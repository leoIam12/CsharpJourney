using System;

namespace Method_Ex01_BMICalculator
{
    class Program
    {
        static double CalculateBMI(double weight, double height)
        {
            double imc = 0;
            imc = weight / (height * height);

            return imc;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("-----> Calcular o IMC para alguém <-----\n");

            Console.WriteLine("---> Insira os dados da Pessoa <---");

            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Peso: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double result = CalculateBMI(weight, height);

            Console.Write("\nO seu Índice de Massa Corporal é: " + Math.Round(result, 2));


            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}