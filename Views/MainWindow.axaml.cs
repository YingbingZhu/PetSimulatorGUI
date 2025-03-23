using Avalonia.Media.Imaging;
using Avalonia.Platform.Storage;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform;
using PetSimulatorGUI.ViewModels;
using System;

namespace PetSimulatorGUI;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel viewModel;

    public MainWindow(string petImagePath)
    {
        InitializeComponent();
        var image = this.FindControl<Image>("PetImage");
        var stream = AssetLoader.Open(new Uri(petImagePath));
        image.Source = new Bitmap(stream);


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
