using System;

namespace Tutorial_Ex07_PediatricsDischargeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Aplicação simples para quando os médicos dão alta às crianças na pediatria. <-----\n");

            int[] ageKids = new int[4];
            int maxAge = 0;
            int minAge = 0;

            for (int age = 0; age < ageKids.Length; age++)
            {
                Console.Write($"Insira a Idade da Criança ({age + 1}): ");
                ageKids[age] = Convert.ToInt32(Console.ReadLine());

                if (ageKids[age] >= 0 && ageKids[age] <= 17)
                {
                    if (age == 0)
                    {
                        maxAge = ageKids[age];
                        minAge = ageKids[age];
                    }
                    else
                    {
                        if (ageKids[age] > maxAge)
                        {
                            maxAge = ageKids[age];
                        }
                        if (ageKids[age] < minAge)
                        {
                            minAge = ageKids[age];
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\n[Erro]: A idade da Criança {age + 1} não está no intervalo (0 a 17 anos). Tente novamente!");
                    age--;
                }            
            }
            

            Console.WriteLine($"\nMaior idade: {maxAge} | Menor idade: {minAge}");

            Console.Write("Clique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}