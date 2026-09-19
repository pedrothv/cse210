using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("João", 3, 16);
        string textoDaEscritura = "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.";

        Escritura escritura = new Escritura(referencia, textoDaEscritura);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTexto());

            if (escritura.EstaCompletamenteEscondida())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Pressione Enter para continuar, ou digite 'sair' para encerrar: ");
            string entrada = Console.ReadLine();

            if (entrada == "sair")
            {
                break;
            }

            escritura.EsconderPalavrasAleatorias(3);
        }
    }
}