using System;

namespace OOP_Ex05_HotelManager
{
    class Room //Minha classe quarto
    {
        public int roomNumber;
        private bool isOccupied;
        private double pricePerNight;

        public Room(int room, double price)
        {
            roomNumber = room;
            pricePerNight = price;

            isOccupied = false;
        }

        public void CheckIn()
        {
            if (isOccupied)
            {
                Console.WriteLine($"\n[Erro]: O quarto {roomNumber} encontra-se ocupado!\n");
            }
            else
            {
                isOccupied = true; //o quarto fica ocupado
                Console.WriteLine($"\nCheck-In efetuado com sucesso. Bem-Vindo!\n");
            }
        }

        public void CheckOut(int nights)
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\n[Erro]: Não podes fazer checkout do quarto {roomNumber} porque está vazio.\n");
            }
            else
            {
                isOccupied = false; //o quarto fica livre novamente

                double totalPay = (double)nights * pricePerNight;
                Console.WriteLine($"\nTotal a Pagar: {Math.Round(totalPay, 2)}£.\n");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"\nNúmero do Quarto: {roomNumber}.");
            Console.WriteLine($"Preço por Noite: {pricePerNight}£.");

            if (isOccupied)
            {
                Console.WriteLine("Estado do Quarto: Ocupado.\n");
            }
            else
            {
                Console.WriteLine("Estado do Quarto: Livre.\n");
            }
        }
    }
}
