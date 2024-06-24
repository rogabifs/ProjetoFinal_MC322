using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class QuartoViewModel
    {
        private readonly QuartoModel _quartoModel;

        public QuartoViewModel(QuartoModel quartoModel)
        {
            _quartoModel = quartoModel;
        }

        public int Numero => _quartoModel.GetNumero();
        public string Tipo => _quartoModel.GetTipo();
        public string Disponibilida => _quartoModel.GetDisponivel() ? "Disponível" : "Indisponível";

        // Optional method to update availability (if needed)
        public void SetDisponivel(bool disponivel)
        {
            _quartoModel.SetDisponivel(disponivel);
            // Raise property changed event (if using a framework)
            
        }
    }
}
