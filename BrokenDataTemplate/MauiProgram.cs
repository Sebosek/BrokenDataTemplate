using BrokenDataTemplate.Controls;
using BrokenDataTemplate.Views;
using BrokenDataTemplate.Views.ViewModel;
using Microsoft.Extensions.Logging;

namespace BrokenDataTemplate;

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

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<ObservableCollectionViewModel>();
        builder.Services.AddSingleton<AppContentView, ObservableCollectionView>();
        builder.Services.AddSingleton<AppContentView, EmptyView>();
		return builder.Build();
	}
}
