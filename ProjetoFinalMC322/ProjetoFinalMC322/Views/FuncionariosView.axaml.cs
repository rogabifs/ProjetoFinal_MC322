using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ProjetoFinalMC322.Views;

public partial class FuncionariosView : UserControl
{
    public FuncionariosView()
    {
        InitializeComponent();
        funcionarios.ItemsSource = new string[]
        {
            "funcionario 1", "funcionario 2"
            
            

        };
    }
}