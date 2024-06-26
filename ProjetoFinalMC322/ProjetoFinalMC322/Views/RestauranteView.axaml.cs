using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProjetoFinalMC322.ViewModels;

namespace ProjetoFinalMC322.Views;

public partial class RestauranteView : UserControl
{
    private RestauranteViewModel viewModel = new RestauranteViewModel();
    public RestauranteView()
    {
        InitializeComponent();
        pratos.ItemsSource = viewModel.getMock();
    }
}