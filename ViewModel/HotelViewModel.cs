using HelloWorld.Model;
using ProjetoFinal_MC322.Model;
using ProjetoFinal_MC322.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class HotelViewModel : BaseViewModel
    {
        private readonly HotelModel _hotelModel;

        public HotelViewModel(HotelModel hotelModel)
        {
            _hotelModel = hotelModel;
        }

        public List<ClienteViewModel> Clientes => _hotelModel.Clientes.Select(cliente => new ClienteViewModel(new ClienteModel())).ToList();

        public List<QuartoModel> QuartosDisponiveis => _hotelModel.QuartosDisponiveis();

        public List<FuncionarioViewModel> Funcionarios => _hotelModel.Funcionarios.Select(funcionario => new FuncionarioViewModel(funcionario)).ToList();

        public RestauranteViewModel Restaurante => new RestauranteViewModel(_hotelModel.Restaurante);

        public void AdicionarQuarto(QuartoModel quartoModel)
        {
            _hotelModel.AdicionarQuarto(quartoModel);
        }

        public void ReservarQuarto(ClienteViewModel clienteViewModel, int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            _hotelModel.ReservaQuarto(clienteViewModel, numeroQuarto, checkIn, checkOut);
        }
    }

}
