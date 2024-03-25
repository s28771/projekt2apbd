using projekt2abd.Exceptions;

namespace projekt2abd;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(int height, double ownWeight, int depth, double maximumLoadCapacity, string containerType, double pressure)
        : base(height, ownWeight, depth, maximumLoadCapacity, containerType)
    {
        Pressure = pressure;
    }

    public override void LoadCargo(double mass)
    {
        if (mass > MaximumLoadCapacity)
        {
            NotifyHazard($"Attempt to overload a {'G'} container with serial number {SerialNumber}. Allowed capacity exceeded.");
            throw new OverfillException("Loading mass exceeds the allowed capacity for this gas container.");
        }
        CargoMass = mass;
    }

    public override void UnloadCargo()
    {
        CargoMass = MaximumLoadCapacity * 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Notification: {message}");
    }
}
