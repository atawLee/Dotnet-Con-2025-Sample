using BMS.Business.Service;
using BMS.Business.State;
using BMS.Domain.Repository;
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
            ApplicationConfiguration.Initialize();
            var builder = Host.CreateApplicationBuilder();
            builder.Services.AddSingleton<FormMain>();
            builder.Services.AddSingleton<ManualGradingForm>();
            builder.Services.AddTransient<ManualGradingPresenter>();
            builder.Services.AddTransient<GradeService>();
            builder.Services.AddTransient<GradeHistoryState>();
            builder.Services.AddTransient<IGradeRepository,StubGradeRepository>();

            var app = builder.Build();
            MainServiceProvider = app.Services;

            var main = MainServiceProvider.GetRequiredService<FormMain>();
            
            Application.Run(main);
        }
    }
}