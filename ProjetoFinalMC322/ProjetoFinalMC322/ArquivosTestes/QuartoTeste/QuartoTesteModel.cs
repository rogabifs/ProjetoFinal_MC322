namespace ProjetoFinalMC322.Model;

public class QuartoTesteModel
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public bool Disponivel { get; set; }

    public QuartoTesteModel(int numero, string tipo, bool disponivel)
    {
        Numero = numero;
        Tipo = tipo;
        Disponivel = disponivel;
    } 
}