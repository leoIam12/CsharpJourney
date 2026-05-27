using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Ex07_TechFix
{
    class Workbench
    {
        private int numberWorkbench;
        private bool isOccupied;

        private Equipment myEquipment; //chamei a classe Equipment

        public Workbench(int numberWorkbench)
        {
            this.numberWorkbench = numberWorkbench;
            isOccupied = false;
        }

        public void CheckIn(string nameCustomer, string nameEquipment)
        {
            if (isOccupied)
            {
                Console.WriteLine($"\n[Erro]: O lugar {numberWorkbench} está ocupado.\n");
            }
            else
            {
                isOccupied = true; //mudar para ocupado

                myEquipment = new Equipment(nameCustomer, nameEquipment); //colocar o telemovel na bancada

                Console.WriteLine($"\nCheck-In efetuado com sucesso para {nameCustomer}.\n");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"\nNome do Cliente: {myEquipment.GetNameCustomer()}");
            Console.WriteLine($"Nome do Cliente: {myEquipment.GetNameEquipment()}\n");

            Console.WriteLine("\nNota do cliente: Confio em ti para usares o encapsulamento certo" +
                              "para o equipamento mostrar os seus dados à bancada\n");

        }

        public void CheckOut()
        {
            if (!isOccupied)
            {
                Console.WriteLine($"\n[Erro]: Não pode fazer o check-out do lugar {numberWorkbench} porque está vazio.\n");
            }
            else
            {
                myEquipment = null; //apagar dados do dono
                isOccupied = false; //mudar para livre

                Console.WriteLine($"\nCheck-out do lugar {numberWorkbench} concluído. O lugar está agora livre.\n");
            }
        }

        public bool GetIsOccupied()
        {
            return isOccupied; //metodo para retornar a variavel de estado que é privada
        }
    }
}
