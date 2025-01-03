using BMS.Business.Service;
using BMS.Repository;
using BMS.Winform;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BMS
{
    public static class Program
    {
        public static IServiceProvider MainServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var host = Host.CreateApplicationBuilder();
            host.Services.AddSingleton<FormMain>();
            host.Services.AddSingleton<ManualGradingForm>();
            host.Services.AddTransient<ManualGradingPresenter>();
            host.Services.AddTransient<GradeService>();
            host.Services.AddTransient<GradeRepository>();

            var app = host.Build();
            MainServiceProvider = app.Services;

            var main = MainServiceProvider.GetRequiredService<FormMain>();

            ApplicationConfiguration.Initialize();
            Application.Run(main);
        }
    }
}