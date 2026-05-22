using System;

namespace OOP_Ex04_MultibancoATMsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----> Foste contratado por um banco para criar o software das caixas automáticas(Multibanco) <-----\n");

            string name;
            double deposit;

            while (true)
            {
                Console.Write("\nInsira o seu Nome: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"\n[ERRO]: Espaço do nome vazio. Tente novamente!");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("\nInsira o seu Depósito Inicial: ");
                string depositString = Console.ReadLine();
                 
                if (double.TryParse(depositString, out deposit) && deposit >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"\n[ERRO]: Valor Incorreto. Tente novamente!");
                }
            }

            BankAccount myAccount = new BankAccount(name, deposit);

            // --- 2. MENU MULTIBANCO ---
            while (true) // Este ciclo é infinito. Só desliga na opção 4.
            {
                Console.Clear(); // Limpa o ecrã a cada nova operação

                string[] optionMenu = { "1 - Ver Saldo", "2 - Depositar", "3 - Levantar", "4 - Sair" };

                Console.WriteLine("-----> Menu <-----\n");
                foreach (string opt in optionMenu)
                {
                    Console.WriteLine(opt);
                }

                Console.Write("\nOpção: ");
                string optionString = Console.ReadLine();
                int option;

                if (int.TryParse(optionString, out option) && option >= 1 && option <= 4)
                {
                    double dp = 0;

                    switch (option)
                    {
                        case 1:
                            myAccount.ShowBalance();
                            break; // Este break sai apenas do switch

                        case 2:
                            while (true) // Ciclo para garantir que não deposita lixo
                            {
                                Console.Write("\nInsira o valor de Depósito: ");
                                string depString = Console.ReadLine();

                                if (double.TryParse(depString, out dp) && dp > 0)
                                {
                                    myAccount.Deposit(dp); // Chama o método da classe!
                                    break; // Sai do ciclo do depósito
                                }
                                else
                                {
                                    Console.WriteLine("\n[ERRO]: Valor Incorreto. Insira um número maior que zero.");
                                }
                            }
                            break;

                        case 3:
                            while (true) // Ciclo para garantir que não levanta lixo
                            {
                                Console.Write("\nInsira o valor do Levantamento: ");
                                string wdString = Console.ReadLine();
                                double wd;

                                if (double.TryParse(wdString, out wd) && wd > 0)
                                {
                                    myAccount.WithDraw(wd); // Chama o método da classe!
                                    break; // Sai do ciclo do levantamento
                                }
                                else
                                {
                                    Console.WriteLine("\n[ERRO]: Valor Incorreto. Insira um número maior que zero.");
                                }
                            }
                            break;

                        case 4:
                            Console.WriteLine("\nSaindo com sucesso. Obrigado por usar o nosso banco!");
                            Environment.Exit(0); // Comando para desligar a aplicação imediatamente!
                            break;
                    }

                    // Pausa para o utilizador ler o que aconteceu antes de limpar o ecrã
                    Console.Write("\nClique Enter para voltar ao Menu...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\n[ERRO]: A opção não é válida. Tente novamente!");
                    Console.Write("Clique Enter para continuar...");
                    Console.ReadLine();
                }
            }
        }
        
    }
}