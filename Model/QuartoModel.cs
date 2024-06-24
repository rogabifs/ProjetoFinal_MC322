using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class QuartoModel
    {
        private int Numero { get; set; }
        private string Tipo { get; set; }
        private bool Disponivel { get; set; }

        //definir os métodos Get e Set para cada atributo
        public int GetNumero()
        {
            return Numero;
        }

        public void SetNumero(int numero)
        {
            Numero = numero;
        }

        public string GetTipo()
        {
            return Tipo;
        }   

        public void SetTipo(string tipo)
        {
            Tipo = tipo;
        }

        public bool GetDisponivel()
        {
            return Disponivel;
        }

        public void SetDisponivel(bool disponivel)
        {
            Disponivel = disponivel;
        }

        public override string ToString()
        {
            return $"Quarto [Número: {Numero}, Tipo: {Tipo}]";
        }

        public QuartoModel(int numero, string tipo, bool disponivel)
        {
            this.Numero = numero;
            this.Tipo = tipo;
            this.Disponivel = disponivel;
        }
    }
}
