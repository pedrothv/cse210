using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco("Rua das Flores, 123", "São Paulo", "SP", "Brasil");
        Cliente cliente1 = new Cliente("Pedro Pereira", endereco1);

        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Teclado", "P001", 150.0, 1));
        pedido1.AdicionarProduto(new Produto("Mouse", "P002", 50.0, 2));

        Endereco endereco2 = new Endereco("123 Main Street", "Nova York", "NY", "EUA");
        Cliente cliente2 = new Cliente("John Smith", endereco2);

        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Monitor", "P003", 800.0, 1));
        pedido2.AdicionarProduto(new Produto("Cabo HDMI", "P004", 20.0, 3));
        pedido2.AdicionarProduto(new Produto("Suporte para Monitor", "P005", 100.0, 1));

        Console.WriteLine(pedido1.ObterEtiquetaDeEmbalagem());
        Console.WriteLine(pedido1.ObterEtiquetaDeEnvio());
        Console.WriteLine($"Preço total: ${pedido1.CalcularCustoTotal()}");
        Console.WriteLine();

        Console.WriteLine(pedido2.ObterEtiquetaDeEmbalagem());
        Console.WriteLine(pedido2.ObterEtiquetaDeEnvio());
        Console.WriteLine($"Preço total: ${pedido2.CalcularCustoTotal()}");
    }
}