public class MetaChecklist : Meta
{
    private int _quantidadeAtual;
    private int _quantidadeNecessaria;
    private int _bonus;

    public MetaChecklist(string nome, string descricao, int pontos, int quantidadeNecessaria, int bonus)
        : base(nome, descricao, pontos)
    {
        _quantidadeAtual = 0;
        _quantidadeNecessaria = quantidadeNecessaria;
        _bonus = bonus;
    }

    public override int RegistrarEvento()
    {
        if (_quantidadeAtual >= _quantidadeNecessaria)
        {
            return 0;
        }

        _quantidadeAtual++;

        if (_quantidadeAtual == _quantidadeNecessaria)
        {
            return _pontos + _bonus;
        }

        return _pontos;
    }

    public override bool EstaCompleta()
    {
        return _quantidadeAtual >= _quantidadeNecessaria;
    }

    public override string ObterDetalhes()
    {
        string status = EstaCompleta() ? "[X]" : "[ ]";

        return $"{status} {_nome} ({_descricao}) -- {_quantidadeAtual}/{_quantidadeNecessaria}";
    }

    public override string ObterRepresentacaoTexto()
    {
        return $"MetaChecklist|{_nome}|{_descricao}|{_pontos}|{_quantidadeAtual}|{_quantidadeNecessaria}|{_bonus}";
    }
}