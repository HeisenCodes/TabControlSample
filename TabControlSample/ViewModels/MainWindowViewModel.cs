using CommunityToolkit.Mvvm.ComponentModel;

namespace TabControlSample.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    public List<ParentTabViewModel> ParentViewModels { get; } = [];

    public MainWindowViewModel()
    {
        ParentViewModels.Add(new ParentTabViewModel("A"));
        ParentViewModels.Add(new ParentTabViewModel("B"));
        ParentViewModels.Add(new ParentTabViewModel("C"));
    }
}
