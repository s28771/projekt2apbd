namespace projekt2abd;

public interface IContainer
{
    double CargoMass { get; set; }
    int Height { get; set; }
    double OwnWeight { get; set; }
    int Depth { get; set; }
    string SerialNumber { get; } 
    double MaximumLoadCapacity { get; set; }

    void LoadCargo(double mass);
    void UnloadCargo();
}

