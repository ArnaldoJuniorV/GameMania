using GameMania.Dados;
using GameMania.Menus;

internal class MenuDeletarJogo : Menu
{
    private IJogoDAO dao;

    public MenuDeletarJogo(IJogoDAO dao) : base("Deletar Jogo")
    {
        this.dao = dao;
    }

    public override bool MostrarOpcao()
    {
        Console.Write("Informe o título do jogo a ser deletado: ");
        var titulo = Console.ReadLine();
        titulo = string.IsNullOrEmpty(titulo) ? "" : titulo;

        var jogo = dao.ObterPorTitulo(titulo);

        if (jogo != null)
        {
            dao.DeletarJogoPorTitulo(titulo);
            Console.WriteLine($"Jogo com título '{titulo}' foi deletado do banco de dados.");
        }
        else
        {
            Console.WriteLine($"Não existe jogo cadastrado com o título '{titulo}'.");
        }

        return false;
    }
}
