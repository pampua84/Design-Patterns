using FactoryMethod.Interfaces;
using FactoryMethod.Models;

namespace FactoryMethod;

public class LinuxProcessorDetailsReader : IProcessorDetailsReader
{
    public ProcessorDetails GetDetails()
    {
        throw new NotImplementedException();
    }
}