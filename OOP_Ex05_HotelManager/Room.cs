using System;

namespace OOP_Ex05_HotelManager
{
    class Room //Minha classe quarto
    {
        public int roomNumber;
        private bool isOccupied;
        private double pricePerNight;
        private double totalPay;

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

        // Recebe o número de noites e a conta do cliente
        public void CheckOut(int nights, CustomerAccount customer)
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\n[Erro]: Não podes fazer checkout do quarto {roomNumber} porque está vazio.\n");
                return;
            }
            else
            {
                //calcula o total a pagar
                totalPay = (double)nights * pricePerNight;
                Console.WriteLine($"\nTotal a Pagar: {Math.Round(totalPay, 2)}£.\n");

                //tenta cobrar na conta do cliente
                bool paymentSuccessful = customer.TryMakePayment(totalPay);

                if (paymentSuccessful)
                {
                    //retira o dinheiro
                    isOccupied = false; //o quarto fica livre novamente
                    Console.WriteLine($"Pagamento concluído! O Check-out do quarto {roomNumber} foi efetuado com sucesso.\n");
                }
                else
                {
                    //não retira o dinheiro
                    Console.WriteLine($"[Erro]: Saldo insuficiente na conta do cliente! Faça um depósito antes do Check-Out.\n");
                }
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

        public bool GetIsOccupied()
        {
            return isOccupied; //Criado para ler e devolver a variavel privada
        }
    }
}
