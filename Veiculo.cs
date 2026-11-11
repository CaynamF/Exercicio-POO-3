namespace Atividade_3
{
    abstract public class Veiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public abstract void ExibirInformacoes();
    }


}