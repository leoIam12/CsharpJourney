using System;
using System.ComponentModel;

namespace OOP_Ex06_CentralParking
{
    class Parking
    {
        private int number;
        private bool isOccupied;

        private Car myCar;

        public Parking(int number)
        {
            this.number = number;
            isOccupied = false;
        }

        public void CheckIn(string licensePlate, string carBrand)
        {
            if (isOccupied) // não deixa entrar porque já está ocupado
            {
                Console.WriteLine($"\n[Erro]: O lugar {number} está ocupado.\n");
            }
            else
            {
                isOccupied = true; //coloca como ocupado agora

                myCar = new Car(licensePlate, carBrand); //colocar o carro no lugar

                Console.WriteLine($"\nCheck-In efetuado com sucesso para o carro {carBrand} com matrícula {licensePlate}.\n");
            }
        }

        public void CheckOut(int place)
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\n[Erro]: Não pode fazer o check-out do lugar {number} porque está vazio.\n");
                return;
            }
            else
            {
                myCar = null; //apaga os dados do carro
                isOccupied = false; //libertei o lugar para um próximo carro

                Console.WriteLine($"\nCheck-out do lugar {number} concluído. O lugar está agora livre.\n");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Matrícula: {myCar.GetPlate()}.\n");
        }

        public bool GetIsOccupied()
        {
            return isOccupied; //Criado para ler e devolver a variavel privada
        }

    }
}
