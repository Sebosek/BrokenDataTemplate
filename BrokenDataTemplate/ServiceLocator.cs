namespace BrokenDataTemplate;

/// <summary>
/// Another workaround...
/// https://github.com/dotnet/maui/issues/14911
/// </summary>
public static class ServiceLocator
{
    public static TService GetService<TService>() => Current.GetService<TService>();

    public static IEnumerable<TService> GetServices<TService>() => Current.GetServices<TService>();

    public static IServiceProvider Current =>
#if WINDOWS10_0_17763_0_OR_GREATER
        MauiWinUIApplication.Current.Services;
#elif ANDROID
            MauiApplication.Current.Services;
#elif IOS || MACCATALYST
        MauiUIApplicationDelegate.Current.Services;
#else
			null;
#endif
}