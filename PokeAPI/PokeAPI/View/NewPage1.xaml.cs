using Android.Gms.Common;
using PokeAPI.Services;
using System.Net.Http.Headers;

namespace PokeAPI.View;

public partial class NewPage1 : ContentPage
{
    private bool _estado;
    private readonly HttpClient _httpClient = new HttpClient();
    private const string AuthorityUrl = "https://arg.globalassistgroup.com/metroinidentity2";
    private Credentials? _credentials;
    private readonly OidcIdentityService _oidcIdentityService;


    static readonly string TAG = "MainActivity";

    internal static readonly string CHANNEL_ID = "my_notification_channel";
    internal static readonly int NOTIFICATION_ID = 100;


    public NewPage1()
    {
        InitializeComponent();
        // const string scope = "openid profile offline_access";
        const string scope = "openid profile";
        _oidcIdentityService = new OidcIdentityService("gnabbermobileclient", "App.CallbackScheme", "App.SignoutCallbackScheme", scope, AuthorityUrl);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (_estado)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        _estado = !_estado;
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        Credentials credentials = await _oidcIdentityService.Authenticate();
        string error = credentials.Error;

        _httpClient.DefaultRequestHeaders.Authorization = credentials.IsError
            ? null
            : new AuthenticationHeaderValue("bearer", credentials.AccessToken);

    }


}