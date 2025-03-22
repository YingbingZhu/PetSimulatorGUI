using Avalonia.Controls;
using PetSimulatorGUI.ViewModels;

namespace PetSimulatorGUI;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel viewModel;

    public MainWindow()
    {
        InitializeComponent();
        viewModel = new MainWindowViewModel();
        DataContext = viewModel;
    }

    private void OnFeedClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        viewModel.Feed();
    }

    private void OnPlayClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        viewModel.Play();
    }

    private void OnSleepClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        viewModel.Sleep();
    }
}
