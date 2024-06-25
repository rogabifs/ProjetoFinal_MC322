using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ProjetoFinalMC322.Views;

public partial class RestauranteView : UserControl
{
    public RestauranteView()
    {
        InitializeComponent();
        pratos.ItemsSource = new string[]
        {
            "prato 1", "prato 2"
            
            

        };
    }
}