using DailyDev.Desktop.ViewModels;
using MvvmCross.ViewModels;

namespace DailyDev.Desktop.Core
{
    public class Ap : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<SiteViewModel>();
        }
    }
}
