using DailyDev.Infrastructure.Common.IOptions;
using DailyDev.Infrastructure.Communication.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace DailyDev.Infrastructure.Communication.Services.Smtp
{
    public class SmtpService : ISmtpService
    {
        private AppSettings appSettings;

        public SmtpService()
        {
            var jsonString = File.ReadAllText("appsettings.json");
            appSettings = JsonConvert.DeserializeObject<AppSettings>(jsonString);
        }
        public void SendEmail(string subject, string body, string to = "", string from = "")
        {
            if (string.IsNullOrEmpty(to))
            {
                to = appSettings.Communication.EmailService.To;
            }
            if (string.IsNullOrEmpty(from))
            {
                from = appSettings.Communication.EmailService.From;
            }
            using (var client = new SmtpClient(appSettings.Communication.EmailService.SmtpServer, appSettings.Communication.EmailService.Port)
            {
                Credentials = new NetworkCredential(appSettings.Communication.EmailService.From, appSettings.Communication.EmailService.Password),
                EnableSsl = true
            })
            {
                using (var emailMessage = new MailMessage() { From = new MailAddress(from), Body = body, Subject = subject, IsBodyHtml = true })
                {
                    emailMessage.To.Add(to);
                    client.Send(emailMessage);
                }
            }
        }
    }
}
