using System;
using System.Linq;

namespace ProjetoEstagio
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Funcionalidades fun = new Funcionalidades();

            
            Console.WriteLine("                     ********** Sistema de Controle de Orçamentos **********");
            Console.WriteLine();

            Console.WriteLine("                                1. Adicionar Orçamento");
            Console.WriteLine("                                2. Listar Orçamento Cadastrado");
            Console.WriteLine("                                3. Mostrar Orçamento de Maior Valor");
            Console.WriteLine("                                4. Mostrar o Orçamento Total de Todos os Orçamentos Cadastrados");
            Console.WriteLine("                                5. Sair");

            Console.WriteLine();

            Console.WriteLine("Escolha uma das Funcionalidades Ácima");
            Console.WriteLine("Ex: Digite '1' para Adicionar Orçamento. Digite '2' para Listar Orçamento Cadastrado...");
            Console.WriteLine();

            Console.Write("Escolha uma Funcionalidade: ");
            int n = int.Parse(Console.ReadLine());
           

            Console.WriteLine();
            if(n > 5) {
                Console.WriteLine("Número de Funcionalidade Inválido!");
                Console.WriteLine();
                
            }

            while (n != 5) {


                switch (n) {

                    case 1:
                        Console.WriteLine("                   ********** Adicionar Orçamento **********");
                        Console.WriteLine();

                        try {

                        
                            Console.Write("Número: ");
                            int num = int.Parse(Console.ReadLine());


                            Console.Write("Cliente: ");
                            string cliente = Console.ReadLine();
                            

                            Console.Write("TotalR$: ");
                            double total = double.Parse(Console.ReadLine());
                            


                            Orçamento orça = new Orçamento(num, cliente, total);
                            fun.CadastroOrcamento(orça);

                            
                        }
                        catch {
                            Console.WriteLine("Dado Inválido!!");
                            Console.WriteLine();
                            
                            break;
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine();

                        Console.WriteLine("                   ********** Listar Orçamentos **********");
                        Console.WriteLine();

                        foreach (Orçamento or in fun.ListarOrçamento() ) {

                            Console.WriteLine("Número: "+or.getNumero()+ ", Cliente: "+or.getCliente()+", TotalR$: "
                                + or.getTotal()+", Data: "+ or.getData());
                            
                        }
                        Console.WriteLine();
                        break;

                    case 3:

                        
                        double maio = fun.Maior();
                        Console.WriteLine("Maior Orçamento com um TotalR$ de: "+ maio);
                        break;

                    case 4:

                        
                        double soma = fun.Soma();
                        Console.WriteLine("Somatorio Total de Todos os Orçamentos Cadastrados: " + soma);


                        break;
                        
                    default:
                        break;

                }
                Console.WriteLine();

                Console.WriteLine("                                1. Adicionar Orçamento");
                Console.WriteLine("                                2. Listar Orçamento Cadastrado");
                Console.WriteLine("                                3. Mostrar Orçamento de Maior Valor");
                Console.WriteLine("                                4. Mostrar o Orçamento Total de Todos os Orçamentos Cadastrados");
                Console.WriteLine("                                5. Sair");

                Console.WriteLine();
                Console.Write("Escolha uma Funcionalidade: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n > 5) {
                    Console.WriteLine("Número de Funcionalidade Inválido!");
                    Console.WriteLine();

                }

            }

            Console.WriteLine("Até Logo!!");
            Console.WriteLine();
        }
    }
}
