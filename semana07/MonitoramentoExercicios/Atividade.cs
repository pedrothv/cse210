using System;

public abstract class Atividade
{
    private DateTime _data;
    private int _minutos;

    public Atividade(DateTime data, int minutos)
    {
        _data = data;
        _minutos = minutos;
    }

    public DateTime ObterData()
    {
        return _data;
    }

    public int ObterMinutos()
    {
        return _minutos;
    }

    public abstract double ObterDistancia();

    public abstract double ObterVelocidade();

    public abstract double ObterRitmo();

    public virtual string ObterResumo()
    {
        return $"{_data:dd MMM yyyy} {GetType().Name} ({_minutos} min) - Distância {ObterDistancia():0.0} km, Velocidade {ObterVelocidade():0.0} km/h, Ritmo {ObterRitmo():0.0} min por km";
    }
}