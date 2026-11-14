namespace Atividade_3
{
    public class EntregaEconomica : Entrega
    {

        public EntregaEconomica()
        {
            
        }

        public EntregaEconomica(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0.4m;
        }
    }
}