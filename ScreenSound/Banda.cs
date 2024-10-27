class Banda
{
    private List<Album> albums = new List<Album>();

    public string Nome { get; } // desse modo não é possivel atribuir nenhum valor diretamente a essa propriedade.  Quando se coloca apenas a opção de leitura na propriedade, você precisa necessariamente inicializar esse valor no construtor ou fornecer um valor à propriedade (lambda).

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\n****************** Discografia da banda {Nome} ************\n\n");

        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}