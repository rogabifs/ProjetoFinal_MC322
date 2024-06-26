using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

namespace ProjetoFinalMC322.Helper;

public static class MessageBox
{
    public static async Task show(string message)
    {
        var dialog = new Window
        {
            Content = new TextBlock { Text = message, Margin = new Thickness(20) },
            Width = 300,
            Height = 200
        };

        await dialog.ShowDialog((Window)Avalonia.Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop ? desktop.MainWindow : null);
    } 
}