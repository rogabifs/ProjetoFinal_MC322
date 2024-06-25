


using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace ProjetoFinalMC322.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isPaneOpen = true;
    
    [ObservableProperty]
    private int _paneLenght = 100;
    
    [ObservableProperty]
    private ViewModelBase  _currentPage = new InicialViewModel();

    [ObservableProperty] 
    private ListItemTemplate? _selectedListItem;

    partial void OnSelectedListItemChanged(ListItemTemplate? value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType);
        if(instance is null) return;
        CurrentPage = (ViewModelBase)instance;
    }
    
    

    public ObservableCollection<ListItemTemplate> Items { get; } = new()
    {
        new ListItemTemplate(typeof(QuartosViewModel)),
        new ListItemTemplate(typeof(ClientesViewModel)),
        new ListItemTemplate(typeof(FuncionariosViewModel)),
        new ListItemTemplate(typeof(RestauranteViewModel))
    };
    
       

    [RelayCommand]
    private void TriggerPane()
    {
        if (IsPaneOpen)
        {
            IsPaneOpen = !IsPaneOpen;
            PaneLenght = 200;
        }
        else
        {
            IsPaneOpen = !IsPaneOpen;
            PaneLenght = 100;
        }
    }
}

public class ListItemTemplate
{
    public ListItemTemplate(Type type )
    {
        ModelType = type;
        Label = type.Name.Replace("ViewModel", "");
    }
    
    public string Label { get; }
    public Type ModelType { get;  }
}