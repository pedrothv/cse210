using System;
using System.Collections.Generic;

public class Video
{
    public string _titulo = "";
    public string _autor = "";
    public int _duracaoEmSegundos;
    public List<Comentario> _comentarios = new List<Comentario>();

    public Video(string titulo, string autor, int duracaoEmSegundos)
    {
        _titulo = titulo;
        _autor = autor;
        _duracaoEmSegundos = duracaoEmSegundos;
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterNumeroDeComentarios()
    {
        return _comentarios.Count;
    }

    public void Exibir()
    {
        Console.WriteLine($"Título: {_titulo}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Duração: {_duracaoEmSegundos} segundos");
        Console.WriteLine($"Número de comentários: {ObterNumeroDeComentarios()}");
        Console.WriteLine("Comentários:");

        foreach (Comentario comentario in _comentarios)
        {
            comentario.Exibir();
        }

        Console.WriteLine();
    }
}