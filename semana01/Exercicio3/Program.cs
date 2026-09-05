using System;

class Program
{
    static void Main(string[] args)
    {
        Random geradorAleatorio = new Random();
        int numeroMagico = geradorAleatorio.Next(1, 101);

        int palpite;

        do
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite == numeroMagico)
            {
                Console.WriteLine("Você adivinhou!");
            }
            else if (palpite < numeroMagico)
            {
                Console.WriteLine("Mais alto");
            }
            else
            {
                Console.WriteLine("Mais baixo");
            }
        } while (palpite != numeroMagico);
    }
}