using HelloWorld.Model;
using ProjetoFinal_MC322.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class RestauranteViewModel : BaseViewModel
    {
        private readonly RestauranteModel _restaurante;

        public RestauranteViewModel(RestauranteModel restaurante)
        {
            _restaurante = restaurante;
        }

        public string Nome
        {
            get => _restaurante.GetNome();
            set
            {
                if (_restaurante.GetNome() != value)
                {
                    _restaurante.SetNome(value);
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }
    }
}
