﻿using Microsoft.Extensions.Logging;
using SQLITEDemo.MVVM.Models;
using SQLITEDemo.Repositorities;

namespace SQLITEDemo
{
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

#if DEBUG
			builder.Logging.AddDebug();
#endif
			builder.Services.AddSingleton<BaseRepository<Customer>>();
			builder.Services.AddSingleton<BaseRepository<Order>>();
			builder.Services.AddSingleton<BaseRepository<Passport>>();

			return builder.Build();
		}
	}
}
