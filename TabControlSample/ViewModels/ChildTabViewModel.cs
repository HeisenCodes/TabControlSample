namespace TabControlSample.ViewModels;

public class ChildTabViewModel
{
    public ChildTabViewModel(string name)
    {
        Name = $"Child {name}";
    }

    public string Name { get; }
}
