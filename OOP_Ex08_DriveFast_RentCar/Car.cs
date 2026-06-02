using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace OOP_Ex08_DriveFast_RentCar
{
    class Car
    {
        public string brandCar;
        public double priceDay;
        private bool isOccupied;

        private string name; //nome do cliente
        private int opDayNumber; //dias que o cliente usou o carro

        public Car(string brandCar, double priceDay)
        {
            this.brandCar = brandCar;
            this.priceDay = priceDay;
            isOccupied = false;
        }

        public bool GetIsOccupied()
        { 
            return isOccupied;
        }

        public void CheckIn()
        {
            if(isOccupied)
            {
                Console.WriteLine($"\nNão pode alugar o {brandCar} porque não está disponível!\n");
            }
            else
            {
                while (true)
                {
                    Console.Write("\nInsira o nome do Cliente: ");
                    name = Console.ReadLine();

                    if(string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Espaço do nome do cliente vazio. Tente novamente!");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.Write($"\nQuantos dias {name} vai ficar com o Carro: ");
                    string opDayString = Console.ReadLine();

                    if (int.TryParse(opDayString, out opDayNumber) && opDayNumber > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n[ERRO]: Quantidade de dias incorreto. Tente novamente!\n");
                    }
                }

                isOccupied = true; //mudar o estado do carro para alugado

                Console.WriteLine("\nCarro alugado com sucesso. Volte Sempre!\n");
            }
        }

        public void ShowStatus()
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\n{brandCar} ({priceDay}£/ dia)\n" +
                                  $"Estado: Disponível\n");
            }
            else
            {
                Console.WriteLine($"\n{brandCar} ({priceDay}£/ dia)\n" +
                                  $"Estado: Alugado por {name}.\n");
            }
        }

        public void CheckOut()
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\nNão pode devolver o {brandCar} porque nunca saiu da garagem!\n");
            }
            else
            {
                double totalPay = opDayNumber * priceDay;


                Console.WriteLine($"\nO cliente {name} devolveu o {brandCar}. Total a pagar: {totalPay}£.\n");

                isOccupied = false; //mudar o estado do carro para disponivel
                name = null;
                opDayNumber = 0;
            }
        }
    }
}