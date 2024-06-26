using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public class RestauranteViewModel: ViewModelBase
{
    private RestauranteModel restauranteModel = new RestauranteModel(nome:"");
    
    public RestauranteModel[] getMock()
    {
        return restauranteModel.GetMockRestaurante();
    }
}