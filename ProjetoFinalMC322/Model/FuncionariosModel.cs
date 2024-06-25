namespace ProjetoFinalMC322.Model;

public class FuncionariosModel
{
    private string Nome;
    private string Cargo;

    public FuncionariosModel(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public string GetNome()
    {
        return Nome;
    }

    public string GetCargo()
    {
        return Cargo;
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }

    public void SetCargo(string cargo)
    {
        Cargo = cargo;
    }

    public override string ToString()
    {
        return $"Funcionario [Nome: {Nome}, Cargo: {Cargo}]";
    } 
}