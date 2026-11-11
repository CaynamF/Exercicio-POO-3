namespace Atividade_3
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook()
        {
            
        }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base()
        {
            Nome = nome;
            Preco = preco;
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"""
                Nome: {Nome}
                Preço: {Preco:C}
                Quantidades de Páginas: {QuantidadePaginas} Hora
            """);
        }
    }
}