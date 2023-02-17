using Plugin.Firebase.CloudMessaging;
using System.Runtime.CompilerServices;

namespace DemoPush;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        CrossFirebaseCloudMessaging.Current.CheckIfValidAsync();
        var token = await CrossFirebaseCloudMessaging.Current.GetTokenAsync();
        DisplayAlert("FCM token", token, "OK");
    }
}

