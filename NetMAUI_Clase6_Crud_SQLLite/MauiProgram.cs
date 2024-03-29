﻿using NetMAUI_Clase6_Crud_SQLLite.ViewModels;
using NetMAUI_Clase6_Crud_SQLLite.Views;
using Microsoft.Extensions.DependencyInjection;
using NetMAUI_Clase6_Crud_SQLLite.Interfaces;
using NetMAUI_Clase6_Crud_SQLLite.Services;

namespace NetMAUI_Clase6_Crud_SQLLite;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		//SQL Lite
		string dbPath = FileAccessHelper.GetPathFile("alumnos.db3");
	//	builder.Services.AddSingleton<AlumnosModels>(s => ActivatorUtilities.CreateInstance<AlumnosModels>(s, dbPath));

     

		return builder.Build();
	}

}
