using DailyDev.Desktop.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace DailyDev.Desktop.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<DashboardViewModel>();
        }
    }
}
