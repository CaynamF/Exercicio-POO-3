namespace Atividade_3
{
    public class JogoDigital : Jogo
    {
        public JogoDigital(string nome, string plataforma) : base(nome, plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Plataforma: {Plataforma}
                Formato: Digital
            """);
        }
    }
}