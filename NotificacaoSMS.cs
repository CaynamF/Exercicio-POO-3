namespace Atividade_3
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Notificação SMS");
        }
    }
}