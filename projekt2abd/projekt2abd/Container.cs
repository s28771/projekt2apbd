
using projekt2abd.Exceptions;

namespace projekt2abd;

public class Container : IContainer
{
    public double CargoMass { get; set; }
    public int Height { get; set; }
    public double OwnWeight { get; set; }
    public int Depth { get; set; }
    private static int lastNumber = 0;
    public string SerialNumber { get; private set; } 
    public double MaximumLoadCapacity { get; set; }

    public Container(int height, double ownWeight, int depth, double maximumLoadCapacity, string containerType)
    {
        Height = height;
        OwnWeight = ownWeight;
        Depth = depth;
        MaximumLoadCapacity = maximumLoadCapacity;
        SerialNumber = GenerateSerialNumber(containerType);
    }

    public virtual void LoadCargo(double mass)
    {
        if (mass > MaximumLoadCapacity)
        {
            throw new OverfillException("Cargo mass exceeds the container's maximum load capacity.");
        }
        CargoMass = mass;
    }

    public void UnloadCargo()
    {
        CargoMass = 0;
    }

    private string GenerateSerialNumber(string type)
    {
        lastNumber++;
        return $"KON-{type}-{lastNumber}";
    }
}
