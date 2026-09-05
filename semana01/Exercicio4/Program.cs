using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero;

        do
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        } while (numero != 0);

        int soma = 0;
        foreach (int n in numeros)
        {
            soma = soma + n;
        }

        double media = soma * 1.0 / numeros.Count;

        int maior = numeros[0];
        foreach (int n in numeros)
        {
            if (n > maior)
            {
                maior = n;
            }
        }

        bool encontrouPositivo = false;
        int