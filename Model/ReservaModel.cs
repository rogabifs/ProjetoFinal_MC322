using ProjetoFinal_MC322.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    // Classe Reserva
    public class ReservaModel
    {
        private QuartoModel? quartoReservado;
        private ClienteModel? cliente;
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
        public ClienteModel? GetCliente()
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

        public QuartoModel? GetQuartoReservado()
        {
            return quartoReservado;
        }


        //SETTERS
        public void SetCliente(ClienteModel cliente)
        {
            this.cliente = cliente;
        }
        public void SetQuartoReservado(QuartoModel quarto)
        {
            this.quartoReservado = quarto;
        }

        public void SetCheckIn(DateTime checkIN)
        {
            this.checkIn = checkIN;
        }
        public void SetCheckOut(DateTime checkOUT)
        {
            this.checkOut = checkOUT;
        }

        //TO STRING
        public override string ToString()
        {
            return $"{quartoReservado}\n{cliente}\ncheckIn: {checkIn}\ncheckOut: {checkOut}";
        }

    }
}
