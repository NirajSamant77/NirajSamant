using Microsoft.Extensions.Logging;
using VolunteerConnect.Services;
using VolunteerConnect.Views;

namespace VolunteerConnect;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // ---------- SERVICES ----------
        builder.Services.AddSingleton<DataService>();

        // ---------- PAGES ----------
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterVolunteerPage>();
        builder.Services.AddTransient<RegisterManagerPage>();
        builder.Services.AddTransient<VolunteerDashboardPage>();
        builder.Services.AddTransient<ManagerDashboardPage>();
        builder.Services.AddTransient<ApplicationsPage>();

        return builder.Build();
    }
}