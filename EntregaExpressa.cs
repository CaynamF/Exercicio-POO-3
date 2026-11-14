namespace Atividade_3
{
    public class EntregaExpressa : Entrega
    {
        public EntregaExpressa()
        {
            
        }

        public EntregaExpressa(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0.8m;
        }
    }
}