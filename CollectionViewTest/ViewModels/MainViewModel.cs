using CollectionViewTest.Models;

namespace CollectionViewTest.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private int _id = 1;
    private int Age = 20;
    public ObservableCollection<Person> People { get; set; } = new();
    

    public MainViewModel()
    {
        PopulateList();
    }

    private void PopulateList()
    {
        People.Clear();
        People.Insert(0, new()
        {
            Id = _id,
            Name = $"Person{_id++}",
            Age = Age++
        });

        People.Insert(0,new()
        {
            Id = _id,
            Name = $"Person{_id++}",
            Age = Age++
        });
    }

    [RelayCommand]
    private void AddPerson()
    {
        People.Insert(0 ,new()
        {
            Id = _id,
            Name = $"Person{_id++}",
            Age = Age++
        });
    }
}
