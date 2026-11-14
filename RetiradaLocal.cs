namespace Atividade_3
{
    public class RetiradaLocal : Entrega
    {
        public RetiradaLocal()
        {
            
        }

        public RetiradaLocal(int distancia) : base (distancia)
        {
            
        }

        public override decimal CalcularFrete()
        {
            return Distancia * 0;
        }
    }

}