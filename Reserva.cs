// Classe Reserva
public class Reserva
{
    private Quarto? quartoReservado;
    private Cliente? cliente;
    private DateTime checkIn;
    private DateTime checkOut;



    public Reserva(){
        this.cliente = null;
        this.quartoReservado = null;
        this.checkIn = DateTime.MinValue;
        this.checkOut = DateTime.MinValue;
    
    }
    
    //GETTERS
    public Cliente? GetCliente(){
            return cliente;        
    }
    
    //SETTERS
    public void SetCliente(Cliente cliente){
        this.cliente = cliente;
    }
     public void SetQuartoReservado(Quarto quarto){
        this.quartoReservado = quarto;
    }
    
    public void SetCheckIn(DateTime checkIN){
        this.checkIn = checkIN;
    }
    public void SetCheckOut(DateTime checkOUT){
        this.checkOut = checkOUT;
    }

    //TO STRING
    public override string ToString(){
        return  $"{quartoReservado}\n{cliente}\ncheckIn: {checkIn}\ncheckOut: {checkOut}";
    }

}