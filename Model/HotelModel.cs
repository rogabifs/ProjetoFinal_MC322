using ProjetoFinal_MC322.Model;
using ProjetoFinal_MC322.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class HotelModel
    {
        private List<ClienteModel> clientes;
        private List<QuartoModel> quartos;
        private List<FuncionarioModel> funcionarios;
        private RestauranteModel restaurante;

        public HotelModel()
        {
            clientes = new List<ClienteModel>();
            quartos = new List<QuartoModel>();
            funcionarios = new List<FuncionarioModel>();
            restaurante = new RestauranteModel("hello");
        }

        public List<ClienteModel> Clientes => clientes;
        public List<QuartoModel> Quartos => quartos;
        public List<FuncionarioModel> Funcionarios => funcionarios;
        public RestauranteModel Restaurante => restaurante;

        //getters and setters
        public List<ClienteModel> GetClientes()
        {
            return clientes;
        }

        public List<QuartoModel> GetQuartos()
        {
            return quartos;
        }

        public List<FuncionarioModel> GetFuncionarios()
        {
            return funcionarios;
        }

        public RestauranteModel GetRestaurante()
        {
            return restaurante;
        }

        public void SetClientes(List<ClienteModel> clientes)
        {
            this.clientes = clientes;
        }

        public void SetQuartos(List<QuartoModel> quartos)
        {
            this.quartos = quartos;
        }


        // Add methods for adding clients, rooms, employees, etc. (e.g., AdicionarCliente, AdicionarFuncionario)
        public void AdicionarQuarto(QuartoModel quarto)
        {
            quartos.Add(quarto);
        }

        public List<QuartoModel> QuartosDisponiveis()
        {
            List<QuartoModel> disponiveis = new List<QuartoModel>();
            foreach (QuartoModel quarto in quartos)
            {
                if (quarto.GetDisponivel())
                {
                    disponiveis.Add(quarto);
                }
            }
            return disponiveis;
        }

        public void ReservaQuarto(ClienteViewModel cliente, int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            foreach (QuartoModel quarto in quartos)
            {
                if (numeroQuarto == quarto.GetNumero())
                {
                    cliente.AdicionarReserva(quarto, checkIn, checkOut);
                    //quarto.SetDisponivel(false); // Update availability in the Model
                    //quartos.Remove(quarto); // Remove from the list if needed (depends on logic)
                    return;
                }
            }
        }
    }

}
