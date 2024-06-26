using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProjetoFinalMC322.Helper;
using ProjetoFinalMC322.Model;

namespace ProjetoFinalMC322.ViewModels;

public partial class QuartoTesteViewModel: ObservableObject
{
    [ObservableProperty]
    private string tipoQuarto;

    [ObservableProperty]
    private int numeroQuarto;

    [ObservableProperty]
    private bool disponivel;

    [RelayCommand]
    private void Salvar()
    {
        var quarto = new QuartosModel(NumeroQuarto, TipoQuarto, Disponivel);
        // Lógica para salvar as informações ou realizar outras ações
        MessageBox.show($"Quarto salvo:\nNúmero: {quarto.Numero}\nTipo: {quarto.Tipo}\nDisponível: {quarto.Disponivel}");
    } 
}