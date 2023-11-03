using System.Management;
using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod;

public class WindowsProcessorDetailsReader : IProcessorDetailsReader
{
    public ProcessorDetails GetDetails()
    {
        var searcher = new ManagementObjectSearcher(new SelectQuery("Win32_Processor"));
        var managementObjectCollection = searcher.Get();
        var managementObject = managementObjectCollection.OfType<ManagementObject>().First();
        
        return new ProcessorDetails
        {
            Manufacturer = managementObject.Properties["Manufacturer"].Value.ToString(),
            Name = managementObject.Properties["Name"].Value.ToString(),
            NumberOfCores = Convert.ToInt32(managementObject.Properties["NumberOfCores"].Value),
            NumberOfLogicalProcessors = Convert.ToInt32(managementObject.Properties["NumberOfLogicalProcessors"].Value)
        };
    }
}