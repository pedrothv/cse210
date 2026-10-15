using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> atividades = new List<Atividade>();

        Corrida corrida = new Corrida("03 Nov 2022", 30, 4.8);
        atividades.Add(corrida);

        Ciclismo ciclismo = new Ciclismo("05 Nov 2022", 45, 20.0);
        atividades.Add(ciclismo);

        Natacao natacao = new Natacao("07 Nov 2022", 45, 30);
        atividades.Add(natacao);

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}