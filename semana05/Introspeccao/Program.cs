using System;

namespace Introspeccao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            while (opcao != "4")
            {
                Console.Clear();
                Console.WriteLine("Opções do Menu:");
                Console.WriteLine("  1. Iniciar atividade de respiração");
                Console.WriteLine("  2. Iniciar atividade de reflexão");
                Console.WriteLine("  3. Iniciar atividade de listagem");
                Console.WriteLine("  4. Sair");
                Console.Write("Selecione uma opção do menu: ");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    AtividadeRespiracao respira = new AtividadeRespiracao();
                    respira.Executar();
                }
                else if (opcao == "2")
                {
                    AtividadeReflexao reflexao = new AtividadeReflexao();
                    reflexao.Executar();
                }
                else if (opcao == "3")
                {
                    AtividadeListagem listagem = new AtividadeListagem();
                    listagem.Executar();
                }
                else if (opcao == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por usar o programa! Até logo.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadLine();
                }
            }
        }
    }
}