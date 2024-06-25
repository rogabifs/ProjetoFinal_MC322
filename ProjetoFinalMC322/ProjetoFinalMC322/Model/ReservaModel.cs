using System;

namespace ProjetoFinalMC322.Model;

public class ReservaModel
{

        private QuartosModel? quartoReservado;
        private ClientesModel? cliente;
        private DateTime checkIn;
        private DateTime checkOut;

        public ReservaModel()
        {
            this.cliente = null;
            this.quartoReservado = null;
            this.checkIn = DateTime.MinValue;
            this.checkOut = DateTime.MinValue;

        }

        //GETTERS
        public ClientesModel? GetCliente()
        {
            return cliente;
        }

        public DateTime GetCheckIn()
        {
            return checkIn;
        }

        public DateTime GetCheckOut()
        {
            return checkOut;
        }

        public QuartosModel? GetQuartoReservado()
        {
            return quartoReservado;
        }


        //SETTERS
        public void SetCliente(ClientesModel cliente)
        {
            this.cliente = cliente;
        }
        public void SetQuartoReservado(QuartosModel quarto)
        {
            this.quartoReservado = quarto;
        }

        public void SetCheckIn(DateTime checkIn)
        {
            this.checkIn = checkIn;
        }
        public void SetCheckOut(DateTime checkOut)
        {
            this.checkOut = checkOut;
        }

        //TO STRING
        public override string ToString()
        {
            return $"{quartoReservado}\n{cliente}\ncheckIn: {checkIn}\ncheckOut: {checkOut}";
        }
        
}