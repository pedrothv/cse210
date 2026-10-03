using System;
using System.Collections.Generic;
using System.Threading;

namespace Introspeccao
{
    public class Atividade
    {
        private string _nome;
        private string _descricao;
        private int _duracao;

        public Atividade(string nome, string descricao)
        {
            _nome = nome;
            _descricao = descricao;
            _duracao = 0;
        }

        public int ObterDuracao()
        {
            return _duracao;
        }

        public void ExibirMensagemInicial()
        {
            Console.Clear();
            Console.WriteLine("--- " + _nome + " ---");
            Console.WriteLine();
            Console.WriteLine(_descricao);
            Console.WriteLine();
            
            Console.Write("Por quantos segundos você gostaria de realizar esta atividade? ");
            string entrada = Console.ReadLine();
            _duracao = int.Parse(entrada);

            Console.Clear();
            Console.WriteLine("Prepare-se para começar...");
            ExibirSpinner(3);
        }

        public void ExibirMensagemFinal()
        {
            Console.WriteLine();
            Console.WriteLine("Muito bem!! Você fez um ótimo trabalho!");
            ExibirSpinner(3);
            Console.WriteLine("Você concluiu a " + _nome + " por " + _duracao + " segundos.");
            ExibirSpinner(4);
        }

        public void ExibirSpinner(int segundos)
        {
            List<string> animacao = new List<string>();
            animacao.Add("|");
            animacao.Add("/");
            animacao.Add("-");
            animacao.Add("\\");

            DateTime horaInicio = DateTime.Now;
            DateTime horaFim = horaInicio.AddSeconds(segundos);

            int i = 0;
            while (DateTime.Now < horaFim)
            {
                string s = animacao[i];
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i = i + 1;

                if (i >= animacao.Count)
                {
                    i = 0;
                }
            }
        }

        public void ExibirContagemRegressiva(int segundos)
        {
            for (int i = segundos; i > 0; i = i - 1)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}