using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjetoFinalMC322.Model;

public class QuartosModel
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public bool Disponivel { get; set; }

    //definir os métodos Get e Set para cada atributo
    public int GetNumero()
    {
        return Numero;
    }

    public void SetNumero(int numero)
    {
        Numero = numero;
    }

    public string GetTipo()
    {
        return Tipo;
    }   

    public void SetTipo(string tipo)
    {
        Tipo = tipo;
    }

    public bool GetDisponivel()
    {
        return Disponivel;
    }

    public void SetDisponivel(bool disponivel)
    {
        Disponivel = disponivel;
    }

    public override string ToString()
    {
        return $"Quarto [Número: {Numero}, Tipo: {Tipo}]";
    }

    public QuartosModel(int numero, string tipo, bool disponivel)
    {
        this.Numero = numero;
        this.Tipo = tipo;
        this.Disponivel = disponivel;
    }
}

public class MockQuartos
{
    public static QuartosModel[] GetMockQuartos()
    {
        QuartosModel[] quartos = new QuartosModel[]
        {
            new QuartosModel(101, "Single", true),
            new QuartosModel(102, "Double", false),
            new QuartosModel(103, "Suite", true),
            new QuartosModel(104, "Single", false),
            new QuartosModel(105, "Double", true)
        };

        return quartos;
    }

    private static QuartosModel RetornaQuarto(QuartosModel quarto)
    {
        return quarto;
    }
    
    public static QuartosModel ListarQuarto(int index)
    { 
        QuartosModel[] listaDeQuartos = GetMockQuartos();
        return listaDeQuartos[index];
    }
}