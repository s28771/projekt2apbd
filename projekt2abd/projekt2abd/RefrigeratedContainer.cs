namespace projekt2abd;

public class RefrigeratedContainer : Container
{
    private Dictionary<string, double> _productTemperatures = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };

    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public RefrigeratedContainer(int height, double ownWeight, int depth, double maximumLoadCapacity, string containerType, string productType, double temperature)
        : base(height, ownWeight, depth, maximumLoadCapacity, containerType)
    {
        ProductType = productType;
        Temperature = temperature;
        ValidateTemperature();
    } 
    private void ValidateTemperature()
    {
        if (_productTemperatures.TryGetValue(ProductType, out double requiredTemperature))
        {
            if (Temperature < requiredTemperature)
            {
                throw new InvalidOperationException($"The temperature of the refrigerated container is too low for {ProductType}. Required temperature is {requiredTemperature}, but current is {Temperature}.");
            }
        }
        else
        {
            throw new InvalidOperationException($"{ProductType} is not a valid product type for a refrigerated container.");
        }
    }
}
