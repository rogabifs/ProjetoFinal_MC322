using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public partial class QuartosViewModel: ViewModelBase{
   private QuartosModel quartos = new QuartosModel(0,"", true); 
   public QuartosModel[] getMockData(){
      
      return quartos.GetMockQuartos();
   }
   
}