namespace GameMania.Menus;

using GameMania.Modelos;

internal class MenuExibirJogosCadastrados: Menu
{

    public MenuExibirJogosCadastrados() : base("Exibindo Jogos Cadastrados")
    {

    }

    public override bool MostrarOpcao()
    {
        var jogos = jogoDAO.ObterTodosOsJogos();
        foreach (var jogo in jogos)
        {
            jogo.ExibirFichaTecnica();
        }
        return false;
    }
}