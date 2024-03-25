using projekt2abd.Exceptions;

namespace projekt2abd;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }

    public LiquidContainer(int height, double ownWeight, int depth, double maximumLoadCapacity, string containerType, bool isHazardous)
        : base(height, ownWeight, depth, maximumLoadCapacity, containerType)
    {
        IsHazardous = isHazardous;
    }

    public override void LoadCargo(double mass)
    {
        double allowedCapacity = IsHazardous ? MaximumLoadCapacity * 0.5 : MaximumLoadCapacity * 0.9;
        if (mass > allowedCapacity)
        {
            NotifyHazard($"Attempt to overload a {'L'} container with serial number {SerialNumber}. Allowed capacity exceeded.");
            throw new OverfillException("Loading mass exceeds the allowed capacity for this liquid container.");
        }
        CargoMass = mass;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"Hazard Notification: {message}");
    }
}
