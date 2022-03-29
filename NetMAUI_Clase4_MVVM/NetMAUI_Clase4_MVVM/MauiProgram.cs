using NetMAUI_Clase4_MVVM.ViewModel;
namespace NetMAUI_Clase4_MVVM;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
		builder.Services.AddTransient<ContadorViewModel>(); 
		return builder.Build();
	}
}
