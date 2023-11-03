using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories;

public class LinuxProcessorDetailsReaderFactory : IProcessorDetailsReaderFactory
{
    public IProcessorDetailsReader CreateReader()
    {
        return new LinuxProcessorDetailsReader();
    }
}