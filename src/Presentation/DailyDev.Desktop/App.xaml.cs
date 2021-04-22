using DailyDev.Desktop.Options;
using DailyDev.Infrastructure.Communication.Interfaces;
using DailyDev.Infrastructure.Communication.Services.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvvmCross;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;
using System;
using System.Windows;

namespace DailyDev.Desktop
{
    public partial class App : MvxApplication
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }
        private IHost _host;

        public App()
        {
            _host = new HostBuilder()
                  .ConfigureAppConfiguration((context, configurationBuilder) =>
                  {
                      configurationBuilder.SetBasePath(context.HostingEnvironment.ContentRootPath);
                      configurationBuilder.AddJsonFile("appsettings.json", optional: false);
                  })
                  .ConfigureServices((context, services) =>
                  {
                      services.Configure<EmailOptions>(context.Configuration);
                      services.AddTransient<ISmtpService, SmtpService>();
                      services.AddSingleton<MainWindow>();
                  })
                  .Build();
        }
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            MvxWpfSetupSingleton.EnsureSingletonAvailable(Dispatcher, MainWindow);
            await _host.StartAsync();
            var mainWindow = _host.Services.GetService<MainWindow>();
            mainWindow.Show();
        }

        private async void Application_Exit(object sender, ExitEventArgs e)
        {
            using (_host)
            {
                await _host.StopAsync(TimeSpan.FromSeconds(5));
            }
        }
    }
}
