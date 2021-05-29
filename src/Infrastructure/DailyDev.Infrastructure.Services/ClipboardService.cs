using DailyDev.Infrastructure.Services.Interfaces;
using System.Threading.Tasks;

namespace DailyDev.Infrastructure.Services
{
    public class ClipboardService : IClipboardService
    {
        public async Task ClearText()
        {
            await TextCopy.ClipboardService.SetTextAsync("");
        }

        public async Task CopyText(string text)
        {
            await TextCopy.ClipboardService.SetTextAsync(text);

        }

        public async Task<string> GetText()
        {
            return await TextCopy.ClipboardService.GetTextAsync();
        }
    }
}
