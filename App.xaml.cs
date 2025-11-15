using VolunteerConnect.Services;
using VolunteerConnect.Views;

namespace VolunteerConnect;

public partial class App : Application
{
    private readonly DataService _dataService;

    public App(DataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;

        // Use NavigationPage instead of Shell for simpler navigation
        MainPage = new NavigationPage(new LoginPage(dataService));
    }

    protected override async void OnStart()
    {
        base.OnStart();
        await _dataService.InitializeAsync();
    }
}