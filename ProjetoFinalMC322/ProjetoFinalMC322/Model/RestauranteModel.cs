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
}