// Classe Cliente
public class Cliente
{
    private string nome;
    private int idade;
    private int cpf;

    private List<Reserva> historicoReservas;

    //da pra adicionar profissao, telefone, sexo, email, endereço

    public Cliente(){   
        historicoReservas = new List<Reserva>();
        nome = string.Empty;
        cpf = 0;
    }

    //GETTERS
    public string  GetNome(){
        return nome;
    } 
    public int  GetIdade(){
        return idade;
    }
    public int  GetCpf(){
        return cpf;
    }
    public List<Reserva>  GetHistoricoReservas(){
        return historicoReservas;
    }

    //SETTERS
    public void SetNome(string nome){
        this.nome = nome;
    }
    public void SetIdade(int idade){
        this.idade = idade;
    }

    public void SetCpf(int cpf){
        this.cpf = cpf;
    }
    
    //METODO ADICIONAR RESERVA SEM CHECKIN SEM CHECKOUT
    public void AdicionarReserva(Cliente cliente, Quarto quartoDisponivel,DateTime CheckIn, DateTime CheckOut){
        Reserva reserva = new Reserva();
        reserva.SetQuartoReservado(quartoDisponivel);
        reserva.SetCliente(cliente);
        reserva.SetCheckIn(CheckIn);
        reserva.SetCheckOut(CheckOut);
        historicoReservas.Add(reserva);


    }
   
    
    
    public override string ToString()
    {
        return  $"Cliente: [Nome: {nome}\n"+
                $"Idade:{idade}\n"+
                $" Cpf: {cpf}]\n";
    }
}