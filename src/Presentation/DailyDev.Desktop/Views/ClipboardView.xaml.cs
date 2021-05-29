using DailyDev.Desktop.ViewModels;
using System.Windows;

namespace DailyDev.Desktop.Views
{
    /// <summary>
    /// Interaction logic for ClipboardView.xaml
    /// </summary>
    public partial class ClipboardView : Window
    {
        public ClipboardView()
        {
            var clipboardVm = new ClipboardViewModel();
            DataContext = clipboardVm;
            InitializeComponent();
        }
    }
}
