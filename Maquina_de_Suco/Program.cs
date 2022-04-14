using System;

namespace Projeto_ABS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            string resposta;

            Console.WriteLine("=======================================");
            Console.WriteLine("=          MÁQUINA DE BEBIDAS         =");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Deseja realizar pedido? (S) Sim - (N) Não");

            // Validação
            do
            {
                resposta = Console.ReadLine().ToUpper();

                if (resposta == "N")
                {
                    Console.WriteLine("\nO programa será encerrado...");
                    Environment.Exit(0);
                }
                else if (resposta != "S")
                {
                    Console.WriteLine("Digito inválido, digite novamente: ");
                }

            } while (resposta != "S");

            RealizarPedido();
        }

        public static void RealizarPedido()
        {
            Console.Clear();
            string resposta;

            Console.WriteLine("=======================================");
            Console.WriteLine("=      ESCOLHA O TIPO DE BEBIDA       =");
            Console.WriteLine("=======================================\n");

            Console.WriteLine("1 - Refrigerante");
            Console.WriteLine("2 - Suco\n");

            Console.Write("Escolha uma opção: ");
            int opcao;
            bool sair = true;
            bool refrigerante = false;
            bool suco = false;

            //Validação
            do
            {
                resposta = Console.ReadLine();
                bool result = Int32.TryParse(resposta, out opcao); //Verifica se foi digitado numero

                if (result)
                {
                    if (!(resposta == "1" || resposta == "2"))
                    {
                        Console.WriteLine("\nOpção não existe!");
                        Console.Write("Digite novamente: ");
                    }

                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Console.Write("Digite novamente: ");
                }

                if (resposta == "1")
                {
                    sair = false;
                }
                else if (resposta == "2")
                {
                    sair = false;
                }

            } while (sair);

            if (resposta == "1")
            {
                refrigerante = true;
            }
            else if (resposta == "2")
            {
                suco = true;
            }

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("=      ESCOLHA O TIPO DE SABOR        =");
            Console.WriteLine("=======================================\n");

            string nomeSabor = "";

            if (refrigerante == true)
            {
                Console.WriteLine("1 - Coca-Cola");
                Console.WriteLine("2 - Guarana\n");
            }
            else if (suco == true)
            {
                Console.WriteLine("1 - Uva");
                Console.WriteLine("2 - Laranja\n");
            }

            Console.Write("Escolha uma opção: ");

            sair = true;
            //Validação
            do
            {
                resposta = Console.ReadLine();
                bool result = Int32.TryParse(resposta, out opcao); //Verifica se foi digitado numero

                if (result)
                {
                    if (!(resposta == "1" || resposta == "2"))
                    {
                        Console.WriteLine("\nOpção não existe!");
                        Console.Write("Digite novamente: ");
                    }

                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Console.Write("Digite novamente: ");
                }

                if (resposta == "1")
                {
                    sair = false;
                }
                else if (resposta == "2")
                {
                    sair = false;
                }

            } while (sair);

            if (resposta == "1")
            {
                if (refrigerante == true)
                {
                    nomeSabor = "Coca-Cola";
                }
                else
                {
                    nomeSabor = "Uva";
                }
            }
            else if (resposta == "2")
            {
                if (refrigerante == true)
                {
                    nomeSabor = "Guarana";
                }
                else
                {
                    nomeSabor = "Laranja";
                }
            }

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("=        DESEJA COLOCAR GELO?         =");
            Console.WriteLine("=======================================\n");

            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Nao\n");

            Console.Write("Escolha uma opção: ");

            sair = true;
            do
            {
                resposta = Console.ReadLine();
                bool result = Int32.TryParse(resposta, out opcao); //Verifica se foi digitado numero

                if (result)
                {
                    if (!(resposta == "1" || resposta == "2"))
                    {
                        Console.WriteLine("\nOpção não existe!");
                        Console.Write("Digite novamente: ");
                    }

                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Console.Write("Digite novamente: ");
                }

                if (resposta == "1")
                {
                    sair = false;
                }
                else if (resposta == "2")
                {
                    sair = false;
                }

            } while (sair);

            bool gelo = false;

            if (resposta == "1")
            {
                gelo = true;
            }
            else if (resposta == "2")
            {
                gelo = false;
            }

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("=        ESCOLHA O TAMANHO DO COPO    =");
            Console.WriteLine("=======================================\n");

            if (refrigerante == true)
            {
                Console.WriteLine("1 - 300 ml");
                Console.WriteLine("2 - 500 ml");
                Console.WriteLine("3 - 700 ml");
            }
            else if (suco == true)
            {
                Console.WriteLine("1 - 300 ml");
                Console.WriteLine("2 - 500 ml");
            }

            Console.Write("Escolha uma opção: ");

            string tamanhoCopo;
            sair = true;
            do
            {
                resposta = Console.ReadLine();
                bool result = Int32.TryParse(resposta, out opcao); //Verifica se foi digitado numero

                if (result)
                {

                    if (!(resposta == "1" || resposta == "2" || (resposta == "3" && refrigerante == true)))
                    {
                        Console.WriteLine("\nOpção não existe!");
                        Console.Write("Digite novamente: ");
                    }

                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Console.Write("Digite novamente: ");
                }

                if (resposta == "1")
                {
                    sair = false;
                }
                else if (resposta == "2")
                {
                    sair = false;

                }
                else if (resposta == "3" && refrigerante == true)
                {
                    sair = false;
                }

            } while (sair);

            tamanhoCopo = resposta;

            Console.Clear();

            Console.WriteLine("=======================================");
            Console.WriteLine("=           TIPO DE PEDIDO            =");
            Console.WriteLine("=======================================\n");

            Console.WriteLine("1 - Take Out");
            Console.WriteLine("2 - Eat In");

            Console.Write("\nEscolha uma opção: ");

            string tipoPedido;
            sair = true;
            do
            {
                resposta = Console.ReadLine();
                bool result = Int32.TryParse(resposta, out opcao); //Verifica se foi digitado numero

                if (result)
                {
                    if (!(resposta == "1" || resposta == "2"))
                    {
                        Console.WriteLine("\nOpção não existe!");
                        Console.Write("Digite novamente: ");
                    }

                }
                else
                {
                    Console.WriteLine("\nOpção inválida!");
                    Console.Write("Digite novamente: ");
                }

                if (resposta == "1")
                {
                    sair = false;
                }
                else if (resposta == "2")
                {
                    sair = false;
                }

            } while (sair);

            tipoPedido = resposta;


            Console.Clear();

            if (tamanhoCopo == "1")
            {
                tamanhoCopo = "300 ml";
            }
            else if (tamanhoCopo == "2")
            {
                tamanhoCopo = "500 ml";
            }
            else if (tamanhoCopo == "3")
            {
                tamanhoCopo = "700 ml";
            }

            string gelos;

            if (gelo)
            {
                if (refrigerante)
                {
                    gelos = "6 Pedras de Gelo";
                }
                else
                {
                    gelos = "12 pedras de Gelo";
                }
            }
            else
            {
                gelos = "Nenhum Gelo";
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("=     PEDIDO REALIZADO COM SUCESSO!   =");
            Console.WriteLine("=======================================");
            Console.WriteLine("========== DETALHES DO PEDIDO =========  \n");

            Console.WriteLine("Bebida: " + (refrigerante ? "Refrigerante" : "Suco"));
            Console.WriteLine("Sabor: " + nomeSabor);
            Console.WriteLine("Tamanho do Copo: " + tamanhoCopo);
            Console.WriteLine("Tipo de Copo: " + (refrigerante ? "Papel" : "Plastico"));
            Console.WriteLine("Quantidade de Gelo: " + gelos);
            Console.WriteLine("Tipo de Pedido: " + (tipoPedido == "1" ? "Take Out" : "Delivery"));

            Console.WriteLine("\n=======================================");

            Console.WriteLine("\nAperte qualquer tecla para finalizar o sistema...");

            Console.ReadKey();
        }

    }
}