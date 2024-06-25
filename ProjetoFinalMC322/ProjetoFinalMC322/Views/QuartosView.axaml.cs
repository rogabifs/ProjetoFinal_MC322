using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ProjetoFinalMC322.Model;
using System.Linq;

namespace ProjetoFinalMC322.Views;

public partial class QuartosView : UserControl
{
    public QuartosView()
    {
        InitializeComponent();
        Quartos.ItemsSource = new QuartosModel[]
        {         
            MockQuartos.ListarQuarto(0),
            MockQuartos.ListarQuarto(1),
            MockQuartos.ListarQuarto(2),
            MockQuartos.ListarQuarto(3),
            MockQuartos.ListarQuarto(4),
        };
    }
}