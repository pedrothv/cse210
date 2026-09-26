using System;

public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public bool EstaNosEUA()
    {
        return _pais == "EUA";
    }

    public string ObterTextoCompleto()
    {
        return $"{_rua}\n{_cidade}, {_estado}\n{_pais}";
    }
}