using System;

public class Registro
{
    public string _pergunta = "";
    public string _resposta = "";
    public string _data = "";
    public string _humor = "";

    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine(_pergunta);
        Console.WriteLine(_resposta);
        Console.WriteLine($"Humor: {_humor}");
        Console.WriteLine();
    }

    public string ObterLinhaParaArquivo()
    {
        return $"{_data}~|~{_pergunta}~|~{_resposta}~|~{_humor}";
    }
}