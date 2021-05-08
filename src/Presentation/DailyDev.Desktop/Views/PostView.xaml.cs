using DailyDev.Desktop.ViewModels;
using System.Windows;

namespace DailyDev.Desktop.Views
{
    /// <summary>
    /// Interaction logic for PostView.xaml
    /// </summary>
    public partial class PostView : Window
    {
        public PostView()
        {
            var postViewModel = new PostViewModel();
            DataContext = postViewModel;

            InitializeComponent();
        }
    }
}
