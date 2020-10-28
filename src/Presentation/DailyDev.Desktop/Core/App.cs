using DailyDev.Desktop.ViewModels;
using MvvmCross.ViewModels;

namespace DailyDev.Desktop.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<DashboardViewModel>();
        }
    }
}
