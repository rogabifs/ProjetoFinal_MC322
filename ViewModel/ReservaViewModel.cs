using HelloWorld.Model;
using ProjetoFinal_MC322.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class ReservaViewModel
    {
        private readonly ReservaModel _reserva;

        public ReservaViewModel()
        {
            _reserva = new ReservaModel();
        }

        public QuartoModel Quarto => _reserva.GetQuartoReservado();
        public ClienteModel ClienteNome => _reserva.GetCliente();
        public DateTime CheckIn => _reserva.GetCheckIn();
        public DateTime CheckOut => _reserva.GetCheckOut();
    }
}
