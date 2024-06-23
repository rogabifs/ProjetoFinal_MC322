// Classe Hotel
public class Hotel{
    private List<Cliente> clientes;
    public List<Quarto> quartos { get; set; }
    public List<Funcionario> funcionarios { get; set; }
    public Restaurante restaurante { get; set; }

    public Hotel(){
        clientes = new List<Cliente>();
        quartos = new List<Quarto>();
        funcionarios = new List<Funcionario>();
        restaurante = new Restaurante("hello");
    }

    //GETTERS
    public List<Cliente> GetClientes(){
        return clientes;
    } 
    
    //METODO ADICIONAR QUARTO
    public void AdicionarQuarto(Quarto quarto){
        quartos.Add(quarto);
        return;
    }

    //METODO LISTAR QUARTOS DISPONIVEIS
    public List<Quarto> QuartosDisponiveis(){
        List<Quarto> disponiveis = new List<Quarto>();
        for (int i = 0;i<quartos.Count; i++){
            if(quartos[i].GetDisponivel()==true){
                disponiveis.Add(quartos[i]);
            }
        }
        return disponiveis;
    }
    //TO STRING LISTAR QUARTOS DISPONIVEIS
    public string ToStringQuartosDisponiveis(){
        string disponiveis = "";
        for(int j=0;j<QuartosDisponiveis().Count;j++){
            disponiveis += "\n" + QuartosDisponiveis()[j].ToString();
        }
        return disponiveis;
    }

     //METODO RESERVA DE QUARTO
    public void ReservaQuarto(Cliente cliente, int numeroQuarto, DateTime CheckIn, DateTime CheckOut){        
        for(int j=0;j<QuartosDisponiveis().Count;j++){
            if(numeroQuarto == QuartosDisponiveis()[j].GetNumero()){
                cliente.AdicionarReserva(cliente,QuartosDisponiveis()[j],CheckIn, CheckOut);
                //QuartosDisponiveis()[j].SetDisponivel(false);
                //QuartosDisponiveis().Remove(QuartosDisponiveis()[j]);
                return;
            }
        }
    }



    public override string ToString()
    {
        return $"Hotel [Quartos: {quartos.Count}, Clientes: {clientes.Count}, Funcionarios: {funcionarios.Count}, Restaurante: {restaurante}]";
    }
}