using System;

public class Ciclismo : Atividade
{
    private double _velocidade;

    public Ciclismo(string data, int minutos, double velocidade) : base("Ciclismo", data, minutos)
    {
        _velocidade = velocidade;
    }

    public override double ObterDistancia()
    {
        return _velocidade * ObterMinutos() / 60;
    }

    public override double ObterVelocidade()
    {
        return _velocidade;
    }

    public override double ObterRitmo()
    {
        return 60 / _velocidade;
    }
}