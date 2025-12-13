using CommunityToolkit.Mvvm.ComponentModel;

namespace TabControlSample.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    public List<ParentTabViewModel> ParentTabViewModels { get; } = [];

    public MainWindowViewModel()
    {
        ParentTabViewModels.Add(new ParentTabViewModel("A"));
        ParentTabViewModels.Add(new ParentTabViewModel("B"));
        ParentTabViewModels.Add(new ParentTabViewModel("C"));
    }
}
