using projekt2abd.Exceptions;

namespace projekt2abd;

class Program
{
    static void Main(string[] args)
    {
        
        ContainerShip ship = new ContainerShip(maxSpeed: 20, maxContainerCount: 100, maxWeightCapacity: 200000);
        
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(height: 250, ownWeight: 2200, depth: 400, maximumLoadCapacity: 30000, containerType: "C", productType: "Bananas", temperature: 13.3);
        Container container1= new Container(250, 1000, 400, 3000, "C" );
        
        ship.Containers.Add(refrigeratedContainer);
        ship.Containers.Add(container1);
        try
        {
            refrigeratedContainer.LoadCargo(10000); 
        }
        catch (OverfillException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine($"Statek może rozwijać prędkość do {ship.MaxSpeed} węzłów.");
        Console.WriteLine($"Maksymalna liczba kontenerów: {ship.MaxContainerCount}");
        Console.WriteLine($"Maksymalna waga ładunku: {ship.MaxWeightCapacity} ton");

        foreach (var container in ship.Containers)
        {
            Console.WriteLine($"Kontener typu {container.GetType().Name}, numer seryjny: {container.SerialNumber}");
        }
        
        Console.ReadLine(); 
        
    }
}
