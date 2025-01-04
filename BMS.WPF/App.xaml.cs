using System.Configuration;
using System.Data;
using System.Windows;
using BMS.Business.Service;
using BMS.Business.State;
using BMS.Domain.Repository;
using BMS.Repository;
using BMS.WPF.View;
using BMS.WPF.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace BMS.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider MainServiceProvider { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var builder = Host.CreateApplicationBuilder();
            builder.Services.AddTransient<GradeService>();
            builder.Services.AddTransient<GradeHistoryState>();
            builder.Services.AddTransient<IGradeRepository, StubGradeRepository>();

            builder.Services.AddSingleton<MainWindow>();
            builder.Services.AddSingleton<MainWindowViewModel>();

            builder.Services.AddTransient<ManualGradeViewModel>();
            builder.Services.AddSingleton<ManualGradeView>();

            var app = builder.Build();

            MainServiceProvider = app.Services;

            var mainWindow = MainServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

        }
    }

}
