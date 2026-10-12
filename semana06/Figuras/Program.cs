using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new List<Figura>();

        Quadrado quadrado = new Quadrado("Vermelho", 5);
        figuras.Add(quadrado);

        Retangulo retangulo = new Retangulo("Azul", 4, 6);
        figuras.Add(retangulo);

        Circulo circulo = new Circulo("Verde", 3);
        figuras.Add(circulo);

        foreach (Figura figura in figuras)
        {
            string cor = figura.ObterCor();
            double area = figura.ObterArea();

            Console.WriteLine($"Cor: {cor} | Área: {area}");
        }
    }
}