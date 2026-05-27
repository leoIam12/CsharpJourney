using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace OOP_Ex07_TechFix
{
    class Program
    {
        static void Main(string[] args)
        {
            int allWorkbench;
            Workbench[] myWorkbench = new Workbench[5];
            Equipment myEquipment;


            for (int i = 0; i < myWorkbench.Length; i++)
            {
                allWorkbench = i + 1;

                myWorkbench[i] = new Workbench(allWorkbench);
            }

            while (true)
            {
                Console.Clear();

                string[] optionMenu = { "1 - Receber Equipamento", "2 - Ver Bancadas", "3 - Entregar Equipamento e Faturar", "4 - Fechar Sistema" };
                foreach (string option in optionMenu)
                {
                    Console.WriteLine(option);
                }

                int optionNumber;
                Console.Write("Opção (1 a 4): ");
                string optionString = Console.ReadLine();

                if (int.TryParse(optionString, out optionNumber) && optionNumber >= 1 && optionNumber <= 4)
                {
                    switch (optionNumber)
                    {
                        case 1:
                            string nameCustomer;
                            while (true)
                            {
                                Console.Write("Nome do Cliente: ");
                                nameCustomer = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(nameCustomer))
                                {
                                    Console.Write("\nEspaço do nome do cliente vazio. Tente novamente!\n");
                                }
                                else
                                {
                                    break;
                                }
                            }

                            string nameEquipment;
                            while (true)
                            {
                                Console.Write("Nome do Equipamento: ");
                                nameEquipment = Console.ReadLine();

                                if (string.IsNullOrWhiteSpace(nameEquipment))
                                {
                                    Console.Write("\nEspaço do nome do equipamento vazio. Tente novamente!\n");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            
                            bool foundPlace = false;

                            for (int i = 0; i < myWorkbench.Length; i++)
                            {
                                if (!myWorkbench[i].GetIsOccupied())
                                {
                                    myWorkbench[i].CheckIn(nameCustomer, nameEquipment);
                                    foundPlace = true;
                                    break;
                                }

                                if (!foundPlace)
                                {
                                    Console.WriteLine("\n[Desculpe]: As Bancadas de reparações estão todas ocupadas!\n");
                                }

                            }

                            break;
                        case 2:
                            int numberPlace2;
                            while (true)
                            {
                                Console.Write("\nQue bancada quer ver(1 a 5) o estado ?: ");
                                string stringPlace2 = Console.ReadLine();

                                if (int.TryParse(stringPlace2, out numberPlace2) && numberPlace2 >= 1 && numberPlace2 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("\nNúmero incorreto. Tente novamente!\n");
                                }
                            }

                            int index2 = numberPlace2 - 1;


                            if (myWorkbench[index2].GetIsOccupied())
                            {
                                Console.WriteLine($"\nBancada {numberPlace2} - Livre\n");
                            }
                            else
                            {
                                Console.WriteLine($"\nBancada {numberPlace2} - Ocupado\n");
                                myWorkbench[index2].ShowStatus();
                            }

                            break;
                        case 3:
                            int numberPlace3;
                            while (true)
                            {
                                Console.Write("\nQue bancada quer fazer o check-out (1 a 5): ");
                                string stringPlace3 = Console.ReadLine();

                                if (int.TryParse(stringPlace3, out numberPlace3) && numberPlace3 >= 1 && numberPlace3 <= 5)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.Write("\nNúmero incorreto. Tente novamente!\n");
                                }
                            }

                            int index3 = numberPlace3 - 1;

                            if (!myWorkbench[index3].GetIsOccupied())
                            {
                                Console.WriteLine($"\n[Erro]: Não existe nenhum check-in feito para o lugar {numberPlace3}.\n" +
                                                  $"Então não pode fazer o check-out. Tente novamente!\n");
                                break; //verifica se não está ocupado então não tem checkin
                            }

                            double numberhours = 0;
                            while (true)
                            {
                                Console.Write("\nInsira quanto tempo de mão de obra para a reparação (em horas): ");
                                string stringhours = Console.ReadLine();
                                if (double.TryParse(stringhours, out numberhours) && numberhours > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Tempo de mão de obra incorreto. Tente novamente!\n");
                                }
                            }

                            double numbercostNewParts = 0;
                            while (true)
                            {
                                Console.Write("\nInsira quanto custa a reparação: ");
                                string stringcostNewParts = Console.ReadLine();
                                if (double.TryParse(stringcostNewParts, out numbercostNewParts) && numbercostNewParts > 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\n[Erro]: Preço de reparação incorreto. Tente novamente!\n");
                                }
                            }

                            double totalPay = 15 + (20 * numberhours) + numbercostNewParts;

                            Console.WriteLine($"\nTotal a Pagar: {totalPay} £.");

                            myWorkbench[index3].CheckOut();

                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"\n[Erro]: Opção Incorreta. Tente novamente!\n");
                    Console.Write("Voltar ao Menu Principal....");
                    Console.ReadLine();
                }
            }
        }
    }
}