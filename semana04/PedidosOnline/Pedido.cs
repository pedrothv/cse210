using System;
using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos = new List<Produto>();
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularCustoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total = total + produto.ObterCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }

        return total;
    }

    public string ObterEtiquetaDeEmbalagem()
    {
        string etiqueta = "Etiqueta de Embalagem:\n";

        foreach (Produto produto in _produtos)
        {
            etiqueta = etiqueta + $"{produto.ObterNome()} (ID: {produto.ObterIdProduto()})\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaDeEnvio()
    {
        string etiqueta = "Etiqueta de Envio:\n";
        etiqueta = etiqueta + $"{_cliente.ObterNome()}\n";
        etiqueta = etiqueta + _cliente.ObterEndereco().ObterTextoCompleto();

        return etiqueta;
    }
}