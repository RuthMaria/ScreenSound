Banda queen = new Banda("Queen");

Musica musica1 = new Musica(queen, "Roxane")
{
    DataLancamento = DateTime.Parse("12/12/2008"),
    Duracao = 120,
    Disponivel = true,
};


/*
 Também pode ser escrito assim:
    Musica musica1 = new Musica(queen, "Roxane");
    musica1.DataLancamento = DateTime.Parse("12/12/2008");
    musica1.Duracao = 120;
    musica1.Disponivel = true;
 */

Musica musica2 = new Musica(queen, "Bohemian Rhapsody") {
    Duracao = 35,
    Disponivel = false,
};


Album albumDoQueen = new Album("A night ar the opera");
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

queen.AdicionarAlbum(albumDoQueen);

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

Console.WriteLine("\n********* Lista de músicas *********\n\n");
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
Console.WriteLine(ep1.Resumo);
podcast.ExibirDetalhes();
