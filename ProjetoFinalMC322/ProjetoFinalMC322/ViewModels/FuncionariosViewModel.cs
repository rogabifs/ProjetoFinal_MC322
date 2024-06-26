using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public class FuncionariosViewModel: ViewModelBase
{
    private FuncionariosModel funcionariosModel= new FuncionariosModel(nome:"",cargo:"");

    public FuncionariosModel[] getMockFuncionarios()
    {
        return funcionariosModel.GetMockFuncionarios();
    }
}