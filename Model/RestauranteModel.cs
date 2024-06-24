using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class RestauranteModel
    {
        private string Nome;

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string novoNome)
        {
            Nome = novoNome;
        }

        public RestauranteModel(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"Restaurante [Nome: {Nome}]";
        }
    }
}
