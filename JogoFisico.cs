namespace Atividade_3
{
    public class JogoFisico : Jogo
    {
        public JogoFisico(string nome, string plataforma) : base(nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Plataforma: {Plataforma}
                Formato: Físico
            """);
        }
    }
}