using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using PetSimulatorGUI.ViewModels;

namespace PetSimulatorGUI;

public partial class PetSelectWindow : Window
{
    public PetSelectWindow()
    {
        InitializeComponent();
    }

    private void OpenMainWindowWithPet(string petImage)
    {
        var mainWindow = new MainWindow(petImage);
        mainWindow.Show();
        Close();
    }

    private void OnDogClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenMainWindowWithPet("avares://PetSimulatorGUI/Assets/dog.png");
    }

    private void OnCatClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        OpenMainWindowWithPet("avares://PetSimulatorGUI/Assets/cat.png");
    }
}