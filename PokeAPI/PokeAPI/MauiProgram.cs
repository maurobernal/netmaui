
using CommunityToolkit.Mvvm.DependencyInjection;
using PokeAPI.Interfaces;
using PokeAPI.Services;
using PokeAPI.View;
using PokeAPI.ViewModel;
using System.Diagnostics;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Shiny.Push;
using Shiny;
using Shiny.Stores;

namespace PokeAPI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{

        var credential = GoogleCredential.FromJson(@"

{
  ""type"": ""service_account"",
  ""project_id"": ""metroin"",
  ""private_key_id"": ""026797745b2f26c633078871531368e587d1a459"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQC2TtwLVMj6w/Ku\nNgn+Hia8iuUj5Q9+32bAOX4+PnBJnGY7f9xOFK28JhtyQ9oO6CHbASeIlan+dO7T\nYqDIALqfW2mBAQwzVxzjlaQ2Yp3NodZBLkFLrB1z7r4jDUsDIssCGdtSPHF+py3X\nv2fHbC3sObsLAx5aA+QRoJ4I2Q/BMwzQ5mq7nKvhqQ0juhCy8W4O79wdvppEk8OA\nMyjqTVSpmbl1c8AK9I3FOwILs9yNQG7oSMNAcWWiUa8jfFqTmlyPNbHyGLIGZGE9\n7PnOF2xzZMu4pOUDvKtlawTrW6jNJWIMcGeCH8a2VTKX/dYzUgJ+b98y/IS/Sc2n\nCfDkf0enAgMBAAECggEASdn7SLnRasg7BHiOprsnHQS1G0vc8ZvlP2Rq8CMSELfD\nMEI1CApXcNsNDkZPTO+bW2EF104tnY9X+hi/ohWthAWfYSt/+kJFSSpi6cccPuNa\n7G+k8tcn3UFvE7r8UqpjC5hW4OLsZQ6rQvVeQIphtgqS6zyZrIRb/QoQSuxHdg8c\nxdrCnx16uqe1+iC3Oz5/Bi5lKJVk6cXzbwntu5X9UHNU6Hh+kn+m98JFcm0xOSGB\nX+y2ldicOfgWcZglhGikmZgbok7y4ktLUhfQJNFA3h9DaJAyVX0wRxm2ztu8SEVa\ngJYF2UofJlpxnvNAmnYLBmcpMgLeFdz/4SeIoDsNKQKBgQDtiernEd+/6yIrdlph\n9IWRsTbz/gOdw//D2LDcDYACvI0qpSyWM9TrLoRZ54QXlhW/t7/BwKxjs6ByU5Zr\nsLbtlMu5f0SJ9hTmJUuEKzreRukM8AcTEA/m5wq/mg7PWQ8AT07KsS0mwdmaG2tZ\nNOGWQ2LyO5nizjaOshWAJZgGGQKBgQDEehHALCBAw8IsZT6JfVIxsCYsxBNlTrZJ\nRFvkAKRUahSBPRA5PCmp86mLp6KLnLwqBPQ6ZABeE9o12Sn52rbzlmg+BE7LstAW\n8qp+EoLI2xVAnDcsnGrntzwHim2Zf30X8FHJy+ji4XAAIewRlhgA/8yH0nU1V9KM\n7mnAS7HzvwKBgEeoBT6ze6Xvjp1B1L4b/3cV2Jf+FqUvDSbNZXzcbbNlocgtj6e3\n9xEDNVXRq11aHzF4gtY2A0sIUuxqHsRZyLUe394TcF+V5nQO6Br014taJM+MUPYF\nMGbdZ7apCLKwEQBs7D3k+NPqQnRktRtyAmNL7LtaE3AB+R9OxYGk1ZlxAoGAKPIv\npNcNWbHyU4I+CDU/3e8R5Z5vVFuVDavbYqbnmFgLMevh56usGykWmm4zJ9lgNXmW\n1Fxm3zRP84zwfIuiOR2NV+9Z5IW9bCricSe2bdmKkk58CSYH+YZsUj39HVI+ZbDF\nusJuJGpLBxwKsJeRJRQqMdwgZR+KV6iQDW05Bs0CgYAdPCohKl0iY2qChSq4LTVP\nXMYneaX4a13t39by7BC4Cl9eGCwXQ2IPlEmlklYOk58XJ27OUadyCzWl4wPJRhMG\niiuGgjVOU3AnlDFSYN0uzldSEd+p7J0Xd1fbSORDKqwqqRtS7WleMKvtPn8fEYsb\nWx0ro5E/brGS/1tnVu1MCw==\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-metroin@metroin.iam.gserviceaccount.com"",
  ""client_id"": ""116919369386712682398"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-metroin%40metroin.iam.gserviceaccount.com""
}");


        FirebaseApp.Create(new AppOptions() { Credential = credential });


        var builder = MauiApp.CreateBuilder();
        try
        {


            builder
                .UseMauiApp<App>()

                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                });



            //builder.Services.AddSingleton<IPushManager, PushManager>();
            builder.Services.UseFirebaseMessaging<MyPushDelegate>();


            builder.Services.AddHttpClient("PokeAPI", o => o.BaseAddress = new Uri("https://pokeapi.co/api/v2/"));


            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<PokeDetailsPage>();
            


            builder.Services.AddTransient<PokeMasterViewModel>();
            builder.Services.AddTransient<PokeDetailsViewModels>();


            builder.Services.AddTransient<IPokeAPIService, PokeAPIService>();

            builder.Services.AddTransient<IKeyValueStoreFactory, KeyValue>();

            builder.Services.AddTransient<NativeAdapter>();



        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Unable to launch : {ex.Message}");
            Shell.Current.DisplayAlert("Error!", ex.Message, "OK");

        }
            return builder.Build();


    }
}

    public class PushManager : IPushManager
{
    public DateTime? CurrentRegistrationTokenDate => throw new NotImplementedException();

    public string CurrentRegistrationToken => throw new NotImplementedException();

    public Task<PushAccessState> RequestAccess(CancellationToken cancelToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UnRegister()
    {
        throw new NotImplementedException();
    }

    public IObservable<PushNotification> WhenReceived()
    {
        throw new NotImplementedException();
    }
}

public class MyPushDelegate : IPushDelegate
{
    public Task OnEntry(PushNotification data)
    {
        throw new NotImplementedException();
    }

    public Task OnReceived(PushNotification data)
    {
        throw new NotImplementedException();
    }

    public Task OnTokenRefreshed(string token)
    {
        throw new NotImplementedException();
    }
}
/*
public class MyPushDelegate : IPushDelegate
{

    readonly IPushManager pushManager;


    public MyPushDelegate( IPushManager pushManager)
    {
        this.pushManager = pushManager;
    }

    public Task OnEntry(PushNotification push)
        => new Task( () => this.Insert("PUSH ENTRY"));

    public Task OnReceived(PushNotification push)
        => new Task(() => this.Insert("PUSH ENTRY"));

    public Task OnTokenRefreshed(string token)
         => new Task(() => this.Insert("PUSH ENTRY"));

    string Insert(string info) => pushManager.CurrentRegistrationToken;
}
*/