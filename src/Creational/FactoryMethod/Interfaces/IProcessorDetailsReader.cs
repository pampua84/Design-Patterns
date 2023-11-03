using FactoryMethod.Models;

namespace FactoryMethod.Interfaces;

public interface IProcessorDetailsReader
{
    ProcessorDetails GetDetails();
}