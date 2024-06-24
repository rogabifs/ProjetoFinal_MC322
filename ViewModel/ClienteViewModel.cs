using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ProjetoFinal_MC322.Model;
using HelloWorld.ViewModel;
using System.Diagnostics;
using HelloWorld.Model;

namespace ProjetoFinal_MC322.ViewModel
{

    public class ClienteViewModel : BaseViewModel
    {
        private ClienteModel _cliente;

        public string Nome
        {
            get => _cliente.GetNome();
            set
            {
                if (_cliente.GetNome() != value)
                {
                    _cliente.SetNome(value);
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        public int Idade
        {
            get => _cliente.GetIdade();
            set
            {
                if (_cliente.GetIdade() != value)
                {
                    _cliente.SetIdade(value);
                    OnPropertyChanged(nameof(Idade));
                }
            }
        }

        public int Cpf
        {
            get => _cliente.GetCpf();
            set
            {
                if (_cliente.GetCpf() != value)
                {
                    _cliente.SetCpf(value);
                    OnPropertyChanged(nameof(Cpf));
                }
            }
        }

        public ClienteModel setClienteModel()
        {
            _cliente.SetIdade(Idade);
            _cliente.SetNome(Nome);
            _cliente.SetCpf(Cpf);

            return _cliente;
        }

        public ObservableCollection<ReservaModel> HistoricoReservas
        {
            get
            {
                return new ObservableCollection<ReservaModel>(_cliente.GetHistoricoReservas());
            }
        }

        public event EventHandler AdicionarReservaEvent; // Event for adding a reservation

        public ClienteViewModel(ClienteModel clienteModel)
        {
            _cliente = clienteModel;
        }

        public void AdicionarReserva(QuartoModel quartoDisponivel, DateTime CheckIn, DateTime CheckOut)
        {
            ReservaModel reserva = new ReservaModel();
            reserva.SetQuartoReservado(quartoDisponivel);
            reserva.SetCheckIn(CheckIn);
            reserva.SetCheckOut(CheckOut);
            HistoricoReservas.Add(reserva);

            // Raise the AdicionarReservaEvent to notify any subscribers
            AdicionarReservaEvent?.Invoke(this, EventArgs.Empty);
        }

        public override string ToString()
        {
            return _cliente.ToString(); // Delegate to the model's ToString
        }
    }

}
