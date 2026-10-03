using System;

namespace Tarefas
{
    public class TarefaDeMatematica : Tarefa
    {
        private string _capituloDoLivro;
        private string _problemas;

        public TarefaDeMatematica(string nomeEstudante, string topico, string capituloDoLivro, string problemas) 
            : base(nomeEstudante, topico)
        {
            _capituloDoLivro = capituloDoLivro;
            _problemas = problemas;
        }

        public string ObterListaDeTarefas()
        {
            return "Capítulo " + _capituloDoLivro + " Problemas " + _problemas;
        }
    }
}