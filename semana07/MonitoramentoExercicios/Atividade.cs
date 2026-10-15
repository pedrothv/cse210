using System;

public abstract class Atividade
{
    private string _nome;
    private string _data;
    private int _minutos;

    public Atividade(string nome, string data, int minutos)
    {
        _nome = nome;
        _data = data;
        _minutos = minutos;
    }

    public int ObterMinutos()
    {
        return _minutos;
    }

    public abstract double ObterDistancia();

    public abstract double ObterVelocidade();

    public abstract double ObterRitmo();

    public string ObterResumo()
    {
        double distancia = ObterDistancia();
        double velocidade = ObterVelocidade();
        double ritmo = ObterRitmo();

        return $"{_data} {_nome} ({_minutos} min) - Distância {distancia:F1} km, Velocidade: {velocidade:F1} km/h, Ritmo: {ritmo:F2} min por km";
    }
}