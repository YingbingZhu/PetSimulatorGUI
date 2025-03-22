using ReactiveUI;
using System;

namespace PetSimulatorGUI.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    private int hunger = 50;
    private int happiness = 50;
    private int energy = 50;

    public string Status => $"Hunger: {hunger}\nHappiness: {happiness}\nEnergy: {energy}";

    public void Feed()
    {
        hunger = Math.Max(0, hunger - 10);
        this.RaisePropertyChanged(nameof(Status));
    }

    public void Play()
    {
        if (energy >= 10)
        {
            happiness = Math.Min(100, happiness + 10);
            energy -= 10;
            this.RaisePropertyChanged(nameof(Status));
        }
    }

    public void Sleep()
    {
        energy = Math.Min(100, energy + 20);
        hunger = Math.Min(100, hunger + 5);
        this.RaisePropertyChanged(nameof(Status));
    }
}
