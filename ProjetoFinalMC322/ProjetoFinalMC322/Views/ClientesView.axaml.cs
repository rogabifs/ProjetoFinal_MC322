using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ProjetoFinalMC322.Views;

public partial class ClientesView : UserControl
{
    public ClientesView()
    {
        InitializeComponent();
        clientes.ItemsSource = new string[]
        {
            "cliente 1", "cliente 2"
            
            

        };
    }
}