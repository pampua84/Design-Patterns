using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories;

public class WindowsProcessorDetailsReaderFactory : IProcessorDetailsReaderFactory
{
    public IProcessorDetailsReader CreateReader()
    {
        return new WindowsProcessorDetailsReader();
    }
}