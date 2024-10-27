class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; set; }
    public string Host { get; set; }
    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n\n*****************Podcast >|{Nome}|< apresentado por [{Host}]*******************");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}.");
    }
}

