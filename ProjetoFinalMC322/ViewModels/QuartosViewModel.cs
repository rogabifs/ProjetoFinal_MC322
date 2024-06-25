using System.Collections.ObjectModel;
using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public class QuartosViewModel: ViewModelBase
{
    public ObservableCollection<QuartosModel> Quartos { get; set; }
    private MockQuartos MockQuartos;

    public QuartosViewModel()
    {
        MockQuartos.GetMockQuartos();
    }
}