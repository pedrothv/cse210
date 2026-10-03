using System;
using System.Collections.Generic;

namespace Introspeccao
{
    public class AtividadeListagem : Atividade
    {
        private List<string> _prompts;
        private List<string> _promptsNaoUsados;

        public AtividadeListagem() 
            : base("Atividade de Listagem", "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")
        {
            _prompts = new List<string>();
            _prompts.Add("Quem são as pessoas que você aprecia?");
            _prompts.Add("Quais são seus pontos fortes pessoais?");
            _prompts.Add("Quem são as pessoas que você ajudou esta semana?");
            _prompts.Add("Quando você sentiu o Espírito Santo neste mês?");
            _prompts.Add("Quem são alguns dos seus heróis pessoais?");

            _promptsNaoUsados = new List<string>(_prompts);
        }

        public void Executar()
        {
            ExibirMensagemInicial();

            string prompt = ObterPromptAleatorio();
            Console.WriteLine();
            Console.WriteLine("Lembre-se do máximo de itens que puder para o seguinte prompt:");
            Console.WriteLine("--- " + prompt + " ---");
            Console.Write("Você pode começar em: ");
            ExibirContagemRegressiva(5);
            Console.WriteLine();

            int duracao = ObterDuracao();
            DateTime horaInicio = DateTime.Now;
            DateTime horaFim = horaInicio.AddSeconds(duracao);

            List<string> itensInseridos = new List<string>();

            while (DateTime.Now < horaFim)
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                if (item != "")
                {
                    itensInseridos.Add(item);
                }
            }

            Console.WriteLine("Você listou " + itensInseridos.Count + " itens!");
            ExibirMensagemFinal();
        }

        private string ObterPromptAleatorio()
        {
            if (_promptsNaoUsados.Count == 0)
            {
                _promptsNaoUsados = new List<string>(_prompts);
            }

            Random rand = new Random();
            int index = rand.Next(_promptsNaoUsados.Count);
            string selecionado = _promptsNaoUsados[index];
            _promptsNaoUsados.RemoveAt(index);

            return selecionado;
        }
    }
}