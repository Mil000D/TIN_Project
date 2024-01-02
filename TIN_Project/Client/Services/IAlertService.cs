using MudBlazor;

namespace TIN_Project.Client.Services
{
    public interface IAlertService
    {
        public void DisplayAlert(string message, Severity severity);
    }
}
