using DailyDev.Infrastructure.Services;

namespace DailyDev.Desktop.ViewModels
{
    public class ClipboardViewModel : ViewModelBase
    {

        #region private fields

        private string _clipboardText;

        #endregion

        #region public fields

        public string ClipboardText
        {
            get => _clipboardText;
            set => SetProperty(ref _clipboardText, value);
        }


        #endregion

        public ClipboardViewModel()
        {
            var clipboardService = new ClipboardService();
            ClipboardText = clipboardService.GetText().GetAwaiter().GetResult();
        }

    }
}
