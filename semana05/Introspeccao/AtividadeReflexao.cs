using System;
using System.Collections.Generic;

namespace Introspeccao
{
    public class AtividadeReflexao : Atividade
    {
        private List<string> _mensagens;
        private List<string> _perguntas;
        private List<string> _mensagensNaoUsadas;
        private List<string> _perguntasNaoUsadas;

        public AtividadeReflexao() 
            : base("Atividade de Reflexão", "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")
        {
            _mensagens = new List<string>();
            _mensagens.Add("Pense em uma ocasião em que você defendeu outra pessoa.");
            _mensagens.Add("Pense em uma ocasião em que você fez algo realmente difícil.");
            _mensagens.Add("Pense em uma ocasião em que você ajudou alguém necessitado.");
            _mensagens.Add("Pense em uma ocasião em que você fez algo verdadeiramente altruísta.");

            _perguntas = new List<string>();
            _perguntas.Add("Por que essa experiência foi significativa para você?");
            _perguntas.Add("Você já fez algo assim antes?");
            _perguntas.Add("Como você começou?");
            _perguntas.Add("Como você se sentiu quando terminou?");
            _perguntas.Add("O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?");
            _perguntas.Add("Qual é a sua coisa favorita sobre essa experiência?");
            _perguntas.Add("O que você pode aprender com essa experiência que se aplica a outras situações?");
            _perguntas.Add("O que você aprendeu sobre si mesmo por meio dessa experiência?");
            _perguntas.Add("Como você pode manter essa experiência em mente no futuro?");

            _mensagensNaoUsadas = new List<string>(_mensagens);
            _perguntasNaoUsadas = new List<string>(_perguntas);
        }

        public void Executar()
        {
            ExibirMensagemInicial();

            string mensagem = ObterMensagemAleatoria();
            Console.WriteLine();
            Console.WriteLine("Considere o seguinte prompt:");
            Console.WriteLine("--- " + mensagem + " ---");
            Console.WriteLine();
            Console.WriteLine("Quando você tiver algo em mente, pressione ENTER para continuar.");
            Console.ReadLine();

            Console.WriteLine("Agora reflita sobre cada uma das seguintes perguntas referentes a essa experiência:");
            Console.Write("Você pode começar em: ");
            ExibirContagemRegressiva(5);
            Console.Clear();

            int duracao = ObterDuracao();
            DateTime horaInicio = DateTime.Now;
            DateTime horaFim = horaInicio.AddSeconds(duracao);

            while (DateTime.Now < horaFim)
            {
                string pergunta = ObterPerguntaAleatoria();
                Console.Write("> " + pergunta + " ");
                ExibirSpinner(5);
                Console.WriteLine();
            }

            ExibirMensagemFinal();
        }

        private string ObterMensagemAleatoria()
        {
            if (_mensagensNaoUsadas.Count == 0)
            {
                _mensagensNaoUsadas = new List<string>(_mensagens);
            }

            Random rand = new Random();
            int index = rand.Next(_mensagensNaoUsadas.Count);
            string selecionada = _mensagensNaoUsadas[index];
            _mensagensNaoUsadas.RemoveAt(index);

            return selecionada;
        }

        private string ObterPerguntaAleatoria()
        {
            if (_perguntasNaoUsadas.Count == 0)
            {
                _perguntasNaoUsadas = new List<string>(_perguntas);
            }

            Random rand = new Random();
            int index = rand.Next(_perguntasNaoUsadas.Count);
            string selecionada = _perguntasNaoUsadas[index];
            _perguntasNaoUsadas.RemoveAt(index);

            return selecionada;
        }
    }
}