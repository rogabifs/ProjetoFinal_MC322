using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProjetoFinalMC322.ViewModels;

namespace ProjetoFinalMC322.Views;

public partial class FuncionariosView : UserControl
{
    private FuncionariosViewModel viewModel = new FuncionariosViewModel();
    public FuncionariosView()
    {
        InitializeComponent();
        funcionarios.ItemsSource = viewModel.getMockFuncionarios();
    }
}