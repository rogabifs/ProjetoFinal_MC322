using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public class ClientesViewModel: ViewModelBase
{
    private ClientesModel clientesModel = new ClientesModel();
    
    public ClientesModel[] getMockClientes()
    {
        return clientesModel.GetMockClientes();
    }
}