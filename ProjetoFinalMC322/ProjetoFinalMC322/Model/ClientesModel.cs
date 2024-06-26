using System.Collections.Generic;

namespace ProjetoFinalMC322.Model;

public class ClientesModel
{
    private string nome;
    private int idade;
    private int cpf;
    private List<ReservaModel> historicoReservas;

    public ClientesModel()
    {
        historicoReservas = new List<ReservaModel>();
        nome = string.Empty;
        cpf = 0;
    }

    // GETTERS
    public string GetNome() => nome;

    public int GetIdade() => idade;

    public int GetCpf() => cpf;

    public List<ReservaModel> GetHistoricoReservas() => historicoReservas;

    // SETTERS
    public void SetNome(string nome) => this.nome = nome;

    public void SetIdade(int idade) => this.idade = idade;

    public void SetCpf(int cpf) => this.cpf = cpf;

    public override string ToString() => $"Cliente: [Nome: {nome}\n" +
                                         $"Idade:{idade}\n" +
                                         $" Cpf: {cpf}]\n"; 
    
    public ClientesModel[] GetMockClientes()
    {
        ClientesModel[] clientes = new ClientesModel[]
        {
            new ClientesModel() { nome = "Maria Silva", idade = 28, cpf = 123456789 },
            new ClientesModel() { nome = "João Souza", idade = 35, cpf = 987654321 },
            new ClientesModel() { nome = "Ana Costa", idade = 24, cpf = 456789123 }
        };

        return clientes;
    }
}