using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas = new List<Meta>();
    private int _pontuacao = 0;

    public void Iniciar()
    {
        int opcao = 0;

        while (opcao != 6)
        {
            Console.WriteLine();
            Console.WriteLine($"Pontuação: {_pontuacao}");
            Console.WriteLine();
            Console.WriteLine("1 - Criar Meta");
            Console.WriteLine("2 - Listar Metas");
            Console.WriteLine("3 - Salvar");
            Console.WriteLine("4 - Carregar");
            Console.WriteLine("5 - Registrar Evento");
            Console.WriteLine("6 - Sair");

            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarMeta();
                    break;

                case 2:
                    ListarMetas();
                    break;

                case 3:
                    SalvarMetas();
                    break;

                case 4:
                    CarregarMetas();
                    break;

                case 5:
                    RegistrarEvento();
                    break;
            }
        }
    }

    private void CriarMeta()
    {
        Console.WriteLine("1 - Meta Simples");
        Console.WriteLine("2 - Meta Eterna");
        Console.WriteLine("3 - Meta Checklist");

        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Descrição: ");
        string descricao = Console.ReadLine();

        Console.Write("Pontos: ");
        int pontos = int.Parse(Console.ReadLine());

        if (tipo == 1)
        {
            _metas.Add(new MetaSimples(nome, descricao, pontos));
        }
        else if (tipo == 2)
        {
            _metas.Add(new MetaEterna(nome, descricao, pontos));
        }
        else if (tipo == 3)
        {
            Console.Write("Quantidade necessária: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Bônus: ");
            int bonus = int.Parse(Console.ReadLine());

            _metas.Add(new MetaChecklist(nome, descricao, pontos, quantidade, bonus));
        }
    }

    private void ListarMetas()
    {
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhes()}");
        }
    }

    private void RegistrarEvento()
    {
        ListarMetas();

        Console.Write("Escolha a meta: ");
        int indice = int.Parse(Console.ReadLine()) - 1;

        int pontosGanhos = _metas[indice].RegistrarEvento();

        _pontuacao += pontosGanhos;

        Console.WriteLine($"Você ganhou {pontosGanhos} pontos!");
    }

    private void SalvarMetas()
    {
        Console.Write("Nome do arquivo: ");
        string arquivo = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(arquivo))
        {
            writer.WriteLine(_pontuacao);

            foreach (Meta meta in _metas)
            {
                writer.WriteLine(meta.ObterRepresentacaoTexto());
            }
        }
    }

    private void CarregarMetas()
    {
        Console.Write("Nome do arquivo: ");
        string arquivo = Console.ReadLine();

        string[] linhas = File.ReadAllLines(arquivo);

        _metas.Clear();

        _pontuacao = int.Parse(linhas[0]);

        for (int i = 1; i < linhas.Length; i++)
        {
            string[] partes = linhas[i].Split('|');

            if (partes[0] == "MetaSimples")
            {
                _metas.Add(new MetaSimples(
                    partes[1],
                    partes[2],
                    int.Parse(partes[3]),
                    bool.Parse(partes[4])));
            }

            if (partes[0] == "MetaEterna")
            {
                _metas.Add(new MetaEterna(
                    partes[1],
                    partes[2],
                    int.Parse(partes[3])));
            }

            if (partes[0] == "MetaChecklist")
            {
                _metas.Add(new MetaChecklist(
                    partes[1],
                    partes[2],
                    int.Parse(partes[3]),
                    int.Parse(partes[5]),
                    int.Parse(partes[6]),
                    int.Parse(partes[4])));
            }
        }
    }
}