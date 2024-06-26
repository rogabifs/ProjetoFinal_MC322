using Avalonia.Controls;
using ProjetoFinalMC322.Model;
using ProjetoFinalMC322.ViewModels;

namespace ProjetoFinalMC322.Views;

public partial class QuartosView : UserControl
{
    private QuartosViewModel viewModel = new QuartosViewModel();
    public QuartosView()
    {
        InitializeComponent();    
        Quartos.ItemsSource = viewModel.getMockData();

    }
    
}