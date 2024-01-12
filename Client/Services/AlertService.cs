using MudBlazor;

namespace TIN_Project.Client.Services
{
    public class AlertService : IAlertService
    {
        private readonly ISnackbar _snackbar;

        public AlertService(ISnackbar snackbar)
        {
            _snackbar = snackbar;
        }
        public void DisplayAlert(string message, Severity severity)
        {
            _snackbar.Clear();
            _snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopCenter;
            _snackbar.Add(message, severity);
        }
    }
}
