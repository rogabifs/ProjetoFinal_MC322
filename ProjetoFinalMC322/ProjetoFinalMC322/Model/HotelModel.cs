using System;
using System.Collections.Generic;
using ProjetoFinalMC322.ViewModels;

namespace ProjetoFinalMC322.Model;

public class HotelModel
{
   private List<ClientesModel> clientes;
        private List<QuartosModel> quartos;
        private List<FuncionariosModel> funcionarios;
        private RestauranteModel restaurante;

        public HotelModel()
        {
            clientes = new List<ClientesModel>();
            quartos = new List<QuartosModel>();
            funcionarios = new List<FuncionariosModel>();
            restaurante = new RestauranteModel("hello");
        }

        public List<ClientesModel> Clientes => clientes;
        public List<QuartosModel> Quartos => quartos;
        public List<FuncionariosModel> Funcionarios => funcionarios;
        public RestauranteModel Restaurante => restaurante;

        //getters and setters
        public List<ClientesModel> GetClientes()
        {
            return clientes;
        }

        public List<QuartosModel> GetQuartos()
        {
            return quartos;
        }

        public List<FuncionariosModel> GetFuncionarios()
        {
            return funcionarios;
        }

        public RestauranteModel GetRestaurante()
        {
            return restaurante;
        }

        public void SetClientes(List<ClientesModel> clientes)
        {
            this.clientes = clientes;
        }

        public void SetQuartos(List<QuartosModel> quartos)
        {
            this.quartos = quartos;
        }


        // Add methods for adding clients, rooms, employees, etc. (e.g., AdicionarCliente, AdicionarFuncionario)
        public void AdicionarQuarto(QuartosModel quarto)
        {
            quartos.Add(quarto);
        }

        public List<QuartosModel> QuartosDisponiveis()
        {
            List<QuartosModel> disponiveis = new List<QuartosModel>();
            foreach (QuartosModel quarto in quartos)
            {
                if (quarto.GetDisponivel())
                {
                    disponiveis.Add(quarto);
                }
            }
            return disponiveis;
        }
}