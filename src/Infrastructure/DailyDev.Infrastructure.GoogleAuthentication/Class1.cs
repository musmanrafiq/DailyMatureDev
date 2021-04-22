using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DailyDev.Infrastructure.GoogleAuthentication
{
    public class Class1
    {
        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { "" },
                    "user", CancellationToken.None);
            }


        }
    }
}
