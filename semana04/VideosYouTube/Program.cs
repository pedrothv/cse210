using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Como aprender C#", "Canal Programação", 600);
        video1.AdicionarComentario(new Comentario("Maria", "Muito bom, me ajudou bastante!"));
        video1.AdicionarComentario(new Comentario("João", "Explicação bem clara."));
        video1.AdicionarComentario(new Comentario("Ana", "Poderia fazer um vídeo sobre listas?"));

        Video video2 = new Video("Receita de bolo simples", "Cozinha Fácil", 480);
        video2.AdicionarComentario(new Comentario("Carlos", "Testei e ficou ótimo!"));
        video2.AdicionarComentario(new Comentario("Fernanda", "Qual o tempo de forno?"));
        video2.AdicionarComentario(new Comentario("Lucas", "Adorei a receita."));

        Video video3 = new Video("Dicas de produtividade", "Vida Organizada", 720);
        video3.AdicionarComentario(new Comentario("Patrícia", "Muito útil, obrigada!"));
        video3.AdicionarComentario(new Comentario("Rafael", "Vou aplicar hoje mesmo."));
        video3.AdicionarComentario(new Comentario("Bianca", "Excelente conteúdo."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Exibir();
        }
    }
}