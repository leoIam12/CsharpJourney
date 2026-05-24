using System;

namespace OOP_Ex05_HotelManager
{
    class CustomerAccount
    {
        private double balanceCustomer;
        private double initialDepositCustumer;
        private bool isPaid = false;

        public void Deposit(double deposit)
        {
            if (deposit <= 0)
            {
                Console.WriteLine($"\nValor incorreto.\n");
            }
            else
            {
                Console.WriteLine($"\nDepósito de {deposit}£ efetuado com sucesso!\n");
                balanceCustomer += deposit;
            }
        }

        //cliente a tentar pagamento
        public bool TryMakePayment(double amountToPay)
        {
            if (balanceCustomer >= amountToPay)
            {
                balanceCustomer -= amountToPay;
                return true; //se for pago com sucesso
            }
            else
            {
                return false; //se o cartão for recusado
            }
        }

        //Se o cliente ter mais credito que gastou, devolve o dinheiro
        public void MoneyLeft(string option)
        {
            if (option.Trim().ToLower() == "sim")
            {
                Console.WriteLine($"\n{balanceCustomer}£ retirado com sucesso. Volte Sempre!\n");
                balanceCustomer -= balanceCustomer;
            }
            else if (option.Trim().ToLower() == "não")
            {
                Console.WriteLine($"\n{balanceCustomer}£ guardado para uma próxima visita!\n");
            }
            else
            {
                Console.WriteLine($"\nResposta incorreta.\n");
            }
        }

        public void ShowCustomerData()
        {
            Console.WriteLine($"Saldo Disponível na conta: {balanceCustomer}£\n");
        }
    }
}
