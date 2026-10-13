using System;

public class Natacao : Atividade
{
    private int _voltas;

    public Natacao(DateTime data, int minutos, int voltas)
        : base(data, minutos)
    {
        _voltas = voltas;
    }

    public override double ObterDistancia()
    {
        return (_voltas * 50) / 1000.0;
    }

    public override double ObterVelocidade()
    {
        return (ObterDistancia() / ObterMinutos()) * 60;
    }

    public override double ObterRitmo()
    {
        return ObterMinutos() / ObterDistancia();
    }
}