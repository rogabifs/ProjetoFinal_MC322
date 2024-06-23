// Classe Funcionario
public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }

    public override string ToString()
    {
        return $"Funcionario [Nome: {Nome}, Cargo: {Cargo}]";
    }
}