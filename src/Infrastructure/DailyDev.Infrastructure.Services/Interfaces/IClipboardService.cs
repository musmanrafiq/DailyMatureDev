using System.Threading.Tasks;

namespace DailyDev.Infrastructure.Services.Interfaces
{
    public interface IClipboardService
    {
        Task CopyText(string text);
        Task<string> GetText();
        Task ClearText();
    }
}
