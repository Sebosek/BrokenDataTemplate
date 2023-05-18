using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Collections.ObjectModel;

namespace BrokenDataTemplate.Views.ViewModel;

public partial class ObservableCollectionViewModel : ObservableObject
{
    [ObservableProperty]
    private int _counter;

    public ObservableCollection<string> Values { get; set; } = new();

    [RelayCommand]
    public void Increase()
    {
        Counter += 1;
    }

    [RelayCommand]
    public void Decrease()
    {
        Counter -= 1;
    }
    
    [RelayCommand]
    public void AddDate()
    {
        Values.Add(DateTime.Now.ToString("R"));
    }
}