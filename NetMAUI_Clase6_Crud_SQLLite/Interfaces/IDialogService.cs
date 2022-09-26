namespace NetMAUI_Clase6_Crud_SQLLite.Interfaces
{
    public interface IDialogService
    {
        Task<string> ShowActionsAsync(string title, string message, string destruction, params string[] buttons);
        Task <bool> ShowAlertAsync(string title, string message, string accept, string cancel);
        Task<bool> ShowConfirmationAsync(string title, string message);
    }
}