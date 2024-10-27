class Musica
{

    // prop + TAB = para criar uma propriedade
    public string coAutor; // se não tiver set e get, são atributo.
    public string Nome { get; }
    public Banda Artista { get; }
    public DateTime DataLancamento { set; get; }
    public bool Disponivel { set; get; } // se tiver set e get são chamadas de propriedades e começam com letra maiuscula
    public int Duracao { set; get; }
    public Genero Genero { get; set; }
    public string DescriçãoResumida 
    { 
        get { 
            return $"A música {Nome} pertence á banda {Artista}";
        }
    }
    /*
    também pode ser escrita assim: 

    public string DescriçãoResumida => $"A música {Nome} pertence á banda {Artista}";

   Dessa forma é chamada de função lambda, onde é usado arrow function
    */

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        } else
        {
            Console.WriteLine("Adquira o plano plus");
        }

    }


    
}

/*
 A principal diferença entre atributo e propriedade é que um atributo é uma variável que armazena um valor, enquanto uma propriedade é uma define como acessar e modificar esse valor.*/