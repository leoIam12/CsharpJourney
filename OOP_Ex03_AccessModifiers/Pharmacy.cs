using System;

namespace OOP_Ex03_AccessModifiers
{
    class Pharmacy //Classe
    {
        private int stock; //Sendo Private, o Main não consegue chamar -> ex: Pharmacy.stock = 500;

        public Pharmacy() //Constructor
        {
            stock = 10; //inicializei stock com 10
        }

        public void SellMedicine() //Method
        {
            if (stock > 0)
            {
                stock--;
                Console.WriteLine($"\nMedicamento vendido! Stock atual: {stock}.\n");
            }
            else
            {
                Console.WriteLine("[ERRO]: Stock esgotado!");
            }
        }

    }
}
