namespace FactoryMethod.Models;

public class ProcessorDetails
{
    public string Name { get; set; }
    public int NumberOfCores { get; set; }
    public int NumberOfLogicalProcessors { get; set; }
    public int L2CacheSize { get; set; }
    public int L3CacheSize { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"NumberOfCores: {NumberOfCores}\n" +
               $"NumberOfLogicalProcessors: {NumberOfLogicalProcessors}\n" +
               $"L2CacheSize: {L2CacheSize}\n" +
               $"L3CacheSize: {L3CacheSize}";
    }
}