using System;

public class Comentario
{
    public string _nomeAutor = "";
    public string _texto = "";

    public Comentario(string nomeAutor, string texto)
    {
        _nomeAutor = nomeAutor;
        _texto = texto;
    }

    public void Exibir()
    {
        Console.WriteLine($"{_nomeAutor}: {_texto}");
    }
}