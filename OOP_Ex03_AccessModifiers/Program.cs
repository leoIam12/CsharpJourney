using System;

namespace OOP_Ex03_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Estudo sobre Modificador de acesso(private serve para proteger dados) <-----\n");

            Pharmacy myPharmacy = new Pharmacy();

            //myPharmacy.stock = 500; -> Dá erro porque a variavel stock é privada

            myPharmacy.SellMedicine();
            myPharmacy.SellMedicine();
            myPharmacy.SellMedicine();

            Console.Write("\nClique Enter para terminar.....");
            Console.ReadLine();
        }
    }
}