using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();

    public void EscreverNovoRegistro(string pergunta, string resposta, string humor)
    {
        Registro registro = new Registro();
        registro._pergunta = pergunta;
        registro._resposta = resposta;
        registro._humor = humor;
        registro._data = DateTime.Now.ToShortDateString();

        _registros.Add(registro);
    }

    public void ExibirDiario()
    {
        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarEmArquivo(string nomeDoArquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(nomeDoArquivo))
        {
            foreach (Registro registro in _registros)
            {
                arquivoSaida.WriteLine(registro.ObterLinhaParaArquivo());
            }
        }
    }

    public void CarregarDeArquivo(string nomeDoArquivo)
    {
        _registros = new List<Registro>();

        string[] linhas = File.ReadAllLines(nomeDoArquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("~|~");

            Registro registro = new Registro();
            registro._data = partes[0];
            registro._pergunta = partes[1];
            registro._resposta = partes[2];
            registro._humor = partes[3];

            _registros.Add(registro);
        }
    }
}