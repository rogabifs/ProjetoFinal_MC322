// Classe Quarto
using System;

public class Quarto
{
    private int numero;
    private string tipo;
    //private double preco;
    private bool disponivel;

    //CONSTRUCTOR
    public Quarto(int numero, string tipo,bool disponivel)
    {
        this.numero = numero;
        this.tipo = tipo;
        this.disponivel = disponivel;
    }

    //GETTERS
    public int  GetNumero(){
        return numero;
    } 
    public string  GetTipo(){
        return tipo;
    }
    public bool  GetDisponivel(){
        return disponivel;
    }

    //SETTERS
    public void SetDisponivel(bool disponivel){
        this.disponivel = disponivel;
    }

    public override string ToString()
    {
        return $"Quarto [Número: {numero}, Tipo: {tipo}]";
    }
}