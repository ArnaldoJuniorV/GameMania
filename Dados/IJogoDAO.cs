namespace GameMania.Dados;
using GameMania.Modelos;

public abstract class IJogoDAO
{
    public abstract void SalvarJogo(Jogo jogo);
    public abstract List<Jogo> ObterTodosOsJogos();
    public abstract Jogo? ObterPorTitulo(string titulo);
    public abstract List<Jogo> FiltrarPorGenero(string genero);
    public abstract void DeletarJogoPorTitulo(string titulo);
}