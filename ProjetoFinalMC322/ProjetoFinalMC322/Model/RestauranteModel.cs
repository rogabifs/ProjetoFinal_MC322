namespace ProjetoFinalMC322.Model;

public class RestauranteModel
{
    private string Nome;

    public string GetNome()
    {
        return Nome;
    }

    public void SetNome(string novoNome)
    {
        Nome = novoNome;
    }

    public RestauranteModel(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Restaurante [Nome: {Nome}]";
    }
    
    public RestauranteModel[] GetMockRestaurante()
    {
        RestauranteModel[] pratos = new RestauranteModel[]
        {
            new RestauranteModel("Salmão Grelhado"),
            new RestauranteModel("Risoto de Cogumelos"),
            new RestauranteModel("Feijoada"),
            new RestauranteModel("Lasanha à Bolonhesa"),
            new RestauranteModel("Salada Caesar"),
            new RestauranteModel("Mousse de Chocolate"),
        };
        return pratos;
    }

    
}