using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TabControlSample.ViewModels;
using TabControlSample.Views;

namespace TabControlSample
{
    public partial class App : Application
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            host.Start();

            App app = new();
            app.InitializeComponent();
            app.MainWindow = host.Services.GetRequiredService<MainWindow>();
            app.MainWindow.Visibility = Visibility.Visible;
            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                // Register your services here
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainWindowViewModel>();

            });
    }
}
