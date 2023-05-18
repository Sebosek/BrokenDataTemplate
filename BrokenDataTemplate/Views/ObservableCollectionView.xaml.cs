using BrokenDataTemplate.Controls;
using BrokenDataTemplate.Views.ViewModel;

namespace BrokenDataTemplate.Views;

public partial class ObservableCollectionView : AppContentView
{
    public ObservableCollectionView(ObservableCollectionViewModel vm)
    {
        BindingContext = vm;

        InitializeComponent();
    }
}