namespace FactoryMethod.Models;

public class ProcessorDetails
{
    public string Manufacturer { get; set; }
    public string Name { get; set; }
    public int NumberOfCores { get; set; }
    public int NumberOfLogicalProcessors { get; set; }

    public override string ToString()
    {
        return $"Manufacturer: {Manufacturer}\n" +
               $"Name: {Name}\n" +
               $"NumberOfCores: {NumberOfCores}\n" +
               $"NumberOfLogicalProcessors: {NumberOfLogicalProcessors}\n";
    }
}