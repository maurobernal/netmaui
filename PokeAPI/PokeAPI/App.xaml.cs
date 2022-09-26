using PokeAPI.View;
using FirebaseAdmin.Messaging;
using FirebaseAdmin.Auth;
using Google.Apis.FirebaseCloudMessaging.v1;
using Shiny.Push;
using Shiny;
using Refit;

namespace PokeAPI;
public partial class App : Application
{
    public App()
	{

        InitializeComponent();
		Current.UserAppTheme = AppTheme.Dark;




        MainPage = new AppShell();



        var instance_auth = FirebaseAuth.DefaultInstance;
		var token = instance_auth.CreateCustomTokenAsync("123").Result; //Login. No es para mensaje
        var auth_messaging = FirebaseMessaging.DefaultInstance;



		var ini = new  Google.Apis.FirebaseCloudMessaging.v1.FirebaseCloudMessagingService.Initializer();
        var t = new Google.Apis.FirebaseCloudMessaging.v1.FirebaseCloudMessagingService(ini);

		/*
        //Mensaje por Token
       Message M = new();
		M.Token = token;
		M.Notification = new Notification() { Title="titulo", Body="Cuerpo"};
		var envio1=  FirebaseMessaging.DefaultInstance.SendAsync(M).Result;






        //Mensaje por Token
        M.Topic = "promociones";
        M.Notification = new Notification() { Title = "titulo", Body = "Cuerpo" };
        var envio2 = FirebaseMessaging.DefaultInstance.SendAsync(M).Result;
		*/
    }

}

