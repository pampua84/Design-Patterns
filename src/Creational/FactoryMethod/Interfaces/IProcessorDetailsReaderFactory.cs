using System.Runtime.InteropServices;

namespace FactoryMethod.Interfaces;

public interface IProcessorDetailsReaderFactory
{
    IProcessorDetailsReader CreateReader();
}