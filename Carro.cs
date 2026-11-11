namespace Atividade_3
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"""
            Marca: {Marca}
            Modelo: {Modelo}
            Quantidade de Portas: {QuantidadePortas}
            """ );
        }
    }
}