using System;

namespace Introspeccao
{
    public class AtividadeRespiracao : Atividade
    {
        public AtividadeRespiracao() 
            : base("Atividade de Respiração", "Esta atividade ajudará você a relaxar, inspirando e expirando lentamente. Limpe sua mente e concentre-se na sua respiração.")
        {
        }

        public void Executar()
        {
            ExibirMensagemInicial();
            int duracao = ObterDuracao();

            DateTime horaInicio = DateTime.Now;
            DateTime horaFim = horaInicio.AddSeconds(duracao);

            Console.WriteLine();
            while (DateTime.Now < horaFim)
            {
                Console.Write("Inspire...");
                ExibirContagemRegressiva(4);
                Console.WriteLine();

                Console.Write("Expire...");
                ExibirContagemRegressiva(4);
                Console.WriteLine();
                Console.WriteLine();
            }

            ExibirMensagemFinal();
        }
    }
}