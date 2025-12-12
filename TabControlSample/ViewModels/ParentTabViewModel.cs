namespace TabControlSample.ViewModels;

public class ParentTabViewModel
{
    public string Name { get; }

    public List<ChildTabViewModel> ChildTabViewModels { get; } = [];

    public ChildTabViewModel SelectedChildTabViewModel { get; set; }

    public ParentTabViewModel(string name)
    {
        Name = name;

        ChildTabViewModels.Add(new ChildTabViewModel($"{name} 1"));
        ChildTabViewModels.Add(new ChildTabViewModel($"{name} 2"));
        ChildTabViewModels.Add(new ChildTabViewModel($"{name} 3"));
        ChildTabViewModels.Add(new ChildTabViewModel($"{name} 4"));
        ChildTabViewModels.Add(new ChildTabViewModel($"{name} 5"));

        SelectedChildTabViewModel = ChildTabViewModels[0];
    }
}
