namespace Atividade_3
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }

        protected string? Plataforma;

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public abstract void ExibirInformacoes();
    }
}