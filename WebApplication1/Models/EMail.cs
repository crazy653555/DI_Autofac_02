namespace WebApplication1.Models
{
    public class EMail : IMessageService
    {
        public string Send(string message)
        {
            return "Autofac-" + message;
        }
    }
}