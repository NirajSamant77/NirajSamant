using VolunteerConnect.Services;
using VolunteerConnect.Views;

namespace VolunteerConnect;

public partial class AppShell : Shell
{
    private readonly DataService _dataService;

    public AppShell(DataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;

        
    }
}