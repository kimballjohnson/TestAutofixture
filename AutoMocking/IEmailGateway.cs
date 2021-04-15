namespace AutoMocking
{
    public interface IEmailGateway
    {
        void Send(EmailMessage message);
    }
}