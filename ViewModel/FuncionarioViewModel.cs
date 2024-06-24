using ProjetoFinal_MC322.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class FuncionarioViewModel : BaseViewModel
    {
        private readonly FuncionarioModel _funcionario;

        public FuncionarioViewModel(FuncionarioModel funcionario)
        {
            _funcionario = funcionario;
        }

        public string Nome
        {
            get => _funcionario.GetNome();
            set
            {
                if (_funcionario.GetNome() != value)
                {
                    _funcionario.SetNome(value);
                    OnPropertyChanged(nameof(Nome));
                }
            }
        }

        public string Cargo
        {
            get => _funcionario.GetCargo();
            set
            {
                if (_funcionario.GetCargo() != value)
                {
                    _funcionario.SetCargo(value);
                    OnPropertyChanged(nameof(Cargo));
                }
            }
        }
    }
}
