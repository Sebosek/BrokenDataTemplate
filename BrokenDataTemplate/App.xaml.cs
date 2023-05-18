namespace BrokenDataTemplate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var page = ServiceLocator.GetService<MainPage>();
		MainPage = new NavigationPage(page);
	}
}
