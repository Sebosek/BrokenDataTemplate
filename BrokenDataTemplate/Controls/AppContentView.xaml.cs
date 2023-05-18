namespace BrokenDataTemplate.Controls;

public partial class AppContentView : ContentView
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(AppContentView), string.Empty);

    public AppContentView()
    {
        InitializeComponent();
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
}