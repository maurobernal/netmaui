using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;

namespace NetMAUI_Clase6_Crud_SQLLite.Services;

public class DialogService : IDialogService
{
    public Task<bool> ShowConfirmationAsync(string title, string message)
    {
        return Application.Current.MainPage.DisplayAlert(title, message, "ok", "no");
    }

    public async Task<bool> ShowAlertAsync(string title, string message, string accept, string cancel)
    {
        return await  Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);

    }

    public Task<string> ShowActionsAsync(string title, string message, string destruction, params string[] buttons)
    {
        return Application.Current.MainPage.DisplayActionSheet(title, message, destruction, buttons);
    }

}
