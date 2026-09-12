using System;
using System.Collections.Generic;

// Fui além dos requisitos básicos adicionando um campo de "humor do dia"
// a cada registro do diário, permitindo à pessoa registrar como estava
// se sentindo, além da pergunta e resposta do dia.

class Program
{
    static void Main(string[] args)
    {
        List<string> perguntas = new List<string>();
        perguntas.Add("Quem foi a pessoa mais interessante com quem interagi hoje?");
        perguntas.Add("Qual foi a melhor parte do meu dia?");
        perguntas.Add("Como vi a mão do Senhor em minha vida hoje?");
        perguntas.Add("Qual foi a emoção mais forte que senti hoje?");
        perguntas.Add("Se eu pudesse fazer uma coisa hoje, o que seria?");

        Diario meuDiario = new Diario();
        Random geradorAleatorio = new Random();

        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Por favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever um novo registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar o diário em um arquivo");
            Console.WriteLine("4. Carregar o diário de um arquivo");
            Console.WriteLine("5. Sair");
            Console.Write("Qual é a sua escolha? ");
            opcao = Console.ReadLine();
            Console.WriteLine();

            if (opcao == "1")
            {
                int indice = geradorAleatorio.Next(0, perguntas.Count);
                string perguntaEscolhida = perguntas[indice];

                Console.WriteLine(perguntaEscolhida);
                string resposta = Console.ReadLine();

                Console.Write("Como você descreveria seu humor hoje? ");
                string humor = Console.ReadLine();

                meuDiario.EscreverNovoRegistro(perguntaEscolhida, resposta, humor);
            }
            else if (opcao == "2")
            {
                meuDiario.ExibirDiario();
            }
            else if (opcao == "3")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeDoArquivo = Console.ReadLine();
                meuDiario.SalvarEmArquivo(nomeDoArquivo);
                Console.WriteLine("Diário salvo com sucesso!");
            }
            else if (opcao == "4")
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeDoArquivo = Console.ReadLine();
                meuDiario.CarregarDeArquivo(nomeDoArquivo);
                Console.WriteLine("Diário carregado com sucesso!");
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção não reconhecida, tente novamente.");
            }
        }
    }
}