using System.Threading.Tasks.Dataflow;

namespace projekt2abd;

public class Container : IContainer
{

    public double CargoWeight { get; set; }
    public double Height { get; set; }

    protected Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new NotImplementedException();
    }
}