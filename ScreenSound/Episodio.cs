class Episodio
{
    private List<string> convidados = new();

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"\n{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";


    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    //código omitido

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}