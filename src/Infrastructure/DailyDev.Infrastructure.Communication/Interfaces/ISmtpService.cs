namespace DailyDev.Infrastructure.Communication.Interfaces
{
    public interface ISmtpService
    {
        void SendEmail(string subject, string body, string to = "", string from = "");
    }
}
