using System;

namespace OOP_Ex05_HotelManager
{
    class Room //Minha classe quarto
    {
        public int roomNumber;
        private bool isOccupied;
        private double pricePerNight;
        private double totalPay;

        private Guest[] guestsInRoom = new Guest[2]; //cada quarto so leva duas pessoas 

        public Room(int room, double price)
        {
            roomNumber = room;
            pricePerNight = price;

            isOccupied = false;
        }

        public void CheckIn(Guest guest1, Guest guest2 = null)
        {
            if (isOccupied)
            {
                Console.WriteLine($"\n[Erro]: O quarto {roomNumber} encontra-se ocupado!\n");
            }
            else
            {
                isOccupied = true; //o quarto fica ocupado

                //Guardar as pessoas no nosso array (as camas do quarto)
                guestsInRoom[0] = guest1; //titular
                guestsInRoom[1] = guest2; //parceiro se houver

                Console.WriteLine($"\nCheck-In efetuado com sucesso para o quarto {roomNumber}.\n");
                Console.WriteLine($"Hóspede Principal (Pagante): {guestsInRoom[0].nameGuest}");

                if (guestsInRoom[1] != null)
                {
                    Console.WriteLine($"Acompanhante: {guestsInRoom[1].nameGuest}");
                }
                Console.WriteLine($"\nBem-Vindos!\n");
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

                //tenta cobrar na conta do cliente(se tiver sucesso no pagamento)
                bool paymentSuccessful = customer.TryMakePayment(totalPay);

                if (paymentSuccessful)
                {
                    //retira o dinheiro
                    isOccupied = false; //o quarto fica livre novamente

                    guestsInRoom[0] = null; //limpa a cama
                    guestsInRoom[1] = null; //limpa a cama

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

        public void ShowGuests()
        {
            Console.WriteLine("\n--- Dados dos Hóspedes no Quarto ---");

            foreach (Guest guest in guestsInRoom)
            {
                if (guest != null) // Bloqueia o fantasma! Só lê se existir alguém.
                {
                    Console.WriteLine($"Nome: {guest.nameGuest}");
                    Console.WriteLine($"Idade: {guest.ageGuest} anos");
                    Console.WriteLine($"BI: {guest.idGuest}");
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}
