// Classe Restaurante
public class Restaurante
{
    public string Nome { get; set; }

    public Restaurante(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Restaurante [Nome: {Nome}]";
    }
}