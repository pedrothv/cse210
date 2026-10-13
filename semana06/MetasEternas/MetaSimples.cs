public class MetaSimples : Meta
{
    private bool _estaCompleta;

    public MetaSimples(string nome, string descricao, int pontos)
        : base(nome, descricao, pontos)
    {
        _estaCompleta = false;
    }

    public override int RegistrarEvento()
    {
        if (_estaCompleta)
        {
            return 0;
        }

        _estaCompleta = true;
        return _pontos;
    }

    public override bool EstaCompleta()
    {
        return _estaCompleta;
    }

    public override string ObterRepresentacaoTexto()
    {
        return $"MetaSimples|{_nome}|{_descricao}|{_pontos}|{_estaCompleta}";
    }
}