using HaydayHelper.Services;
using HaydayHelper.ViewModel;
using Microsoft.Extensions.Logging;

namespace HaydayHelper;

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
		builder.Services.AddSingleton<CropsService>();
		builder.Services.AddSingleton<CropsViewModel>();
		builder.Services.AddTransient<CropsDetailsViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<CropsDetailsView>();
		return builder.Build();
	}
}
