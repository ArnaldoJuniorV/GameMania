namespace GameMania.Menus;

using GameMania.Modelos;

class MenuCadastrarNovoJogo: Menu
{

    public MenuCadastrarNovoJogo(): base("Cadastrar Novo Jogo")
    {

    }

    public override bool MostrarOpcao()
    {
        Console.Write("Qual o título do jogo? ");
        var titulo = Console.ReadLine();
        titulo = string.IsNullOrEmpty(titulo)? "":titulo;
        Console.Write("Qual o genero do jogo? ");
        var genero = Console.ReadLine();
        genero = string.IsNullOrEmpty(genero)? "":genero;
        Console.Write("Qual studio desenvolveu o jogo? ");
        var studio = Console.ReadLine();
        studio = string.IsNullOrEmpty(studio)? "":studio;
        Console.Write("Qual a edição do jogo? ");
        var edicao = Console.ReadLine();
        edicao = string.IsNullOrEmpty(edicao)? "":edicao;

        if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(genero) || string.IsNullOrEmpty(studio) || string.IsNullOrEmpty(edicao))
        {
            Console.WriteLine("Erro: Nenhum dos campos pode estar vazio. Tente novamente.");
            return false;
        } 
        else{
            jogoDAO.SalvarJogo(new Jogo(titulo, genero, studio, edicao));
            Console.WriteLine("Jogo Adicionado com sucesso");
            return false;
        }  
    }
}
