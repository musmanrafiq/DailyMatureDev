namespace DailyDev.Infrastructure.Common.IOptions
{
    public class AppSettings
    {
        public Communication Communication { get; set; }
    }

    public class Communication
    {

        public EmailService EmailService { get; set; }
    }

    public class EmailService
    {
        public int Port { get; set; }
        public string To { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public string SmtpServer { get; set; }
    }
}
