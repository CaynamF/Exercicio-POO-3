namespace Atividade_3
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Preço: {Preco:C}
                Carga Horária: {CargaHoraria}h
            """);
        }
    }
}