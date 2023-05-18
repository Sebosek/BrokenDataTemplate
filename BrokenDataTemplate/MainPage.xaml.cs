using System.Collections.ObjectModel;
using BrokenDataTemplate.Controls;

namespace BrokenDataTemplate;

public partial class MainPage : ContentPage
{
    public MainPage(IEnumerable<AppContentView> views)
    {
        views.ToList().ForEach(ContentViews.Add);
        BindingContext = this;

        InitializeComponent();
    }

    public ObservableCollection<AppContentView> ContentViews { get; } = new();

    protected override void OnAppearing()
    {
        AppContent.Content = ContentViews[0];

        base.OnAppearing();
    }

    private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Label control) return;

        var dict = new Dictionary<string, int>
        {
            { "Bindings", 0 },
            { "Empty", 1 }
        };

        var i = dict[control.Text];
        var view = ContentViews[i];

        AppContent.Content = view;
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        if (sender is not Button control) return;

        var dict = new Dictionary<string, int>
        {
            { "Bindings", 0 },
            { "Empty", 1 }
        };

        var i = dict[control.Text];
        var view = ContentViews[i];

        AppContent.Content = view;
    }
}

