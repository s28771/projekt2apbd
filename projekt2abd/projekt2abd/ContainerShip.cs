namespace projekt2abd;

public class ContainerShip
{
    public List<Container> Containers { get; set; } = new List<Container>();
    public double MaxSpeed { get; set; }
    public int MaxContainerCount { get; set; }
    public double MaxWeightCapacity { get; set; }

    public ContainerShip(double maxSpeed, int maxContainerCount, double maxWeightCapacity)
    {
        Containers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxWeightCapacity = maxWeightCapacity;
    }

    public void AddContainer(Container container)
    {
        if (Containers.Count >= MaxContainerCount)
        {
            throw new InvalidOperationException("Cannot add more containers. The ship is at full capacity.");
        }
        if (GetCurrentTotalWeight() + container.CargoMass > MaxWeightCapacity)
        {
            throw new InvalidOperationException("Cannot add this container. It exceeds the ship's weight capacity.");
        }
        Containers.Add(container);
    }

    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
    }

    public void TransferContainer(ContainerShip otherShip, Container container)
    {
        RemoveContainer(container);
        otherShip.AddContainer(container);
    }

    public double GetCurrentTotalWeight()
    {
        return Containers.Sum(container => container.CargoMass + container.OwnWeight);
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"Ship info: Speed={MaxSpeed} knots, Max Containers={MaxContainerCount}, Current Load={GetCurrentTotalWeight()} tons");
        foreach (var container in Containers)
        {
            Console.WriteLine($"Container: Serial={container.SerialNumber}, Type={container.GetType().Name}, Cargo Mass={container.CargoMass}");
        }
    }
}
