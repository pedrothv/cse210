using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras = new List<Palavra>();

    public Escritura(Referencia referencia, string textoEscritura)
    {
        _referencia = referencia;

        string[] palavrasSeparadas = textoEscritura.Split(" ");

        foreach (string texto in palavrasSeparadas)
        {
            Palavra palavra = new Palavra(texto);
            _palavras.Add(palavra);
        }
    }

    public void EsconderPalavrasAleatorias(int numeroParaEsconder)
    {
        Random geradorAleatorio = new Random();

        for (int i = 0; i < numeroParaEsconder; i++)
        {
            int indice = geradorAleatorio.Next(0, _palavras.Count);
            _palavras[indice].Esconder();
        }
    }

    public string ObterTexto()
    {
        string textoCompleto = _referencia.ObterTexto() + "\n\n";

        foreach (Palavra palavra in _palavras)
        {
            textoCompleto = textoCompleto + palavra.ObterTexto() + " ";
        }

        return textoCompleto;
    }

    public bool EstaCompletamenteEscondida()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaEscondida())
            {
                return false;
            }
        }

        return true;
    }
}