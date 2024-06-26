using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProjetoFinalMC322.ViewModels;

namespace ProjetoFinalMC322.Views;

public partial class ClientesView : UserControl
{
    private ClientesViewModel viewModel = new ClientesViewModel();
    public ClientesView()
    {
        InitializeComponent();
        clientes.ItemsSource = viewModel.getMockClientes();
    }
}