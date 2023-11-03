using System.Runtime.InteropServices;
using FactoryMethod.Factories;
using FactoryMethod.Interfaces;

namespace FactoryMethod;

internal static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IProcessorDetailsReaderFactory factory;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                factory = new WindowsProcessorDetailsReaderFactory();
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                factory = new LinuxProcessorDetailsReaderFactory();
            }
            else
            {
                throw new InvalidOperationException("OS not supported");
            }

            var reader = factory.CreateReader();

            var details = reader.GetDetails();

            Console.WriteLine(details.ToString());

        }
        catch (Exception e)
        {
            Console.WriteLine(e);

        }

        Console.ReadLine();
    }
}