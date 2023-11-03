using FactoryMethod.Interfaces;
using FactoryMethod.Models;
using System.Diagnostics;

namespace FactoryMethod;

public class LinuxProcessorDetailsReader : IProcessorDetailsReader
{
    public ProcessorDetails GetDetails()
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "lscpu",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            }
        };

        process.Start();

        var properties = new Dictionary<string, string>();

        while (process.StandardOutput.EndOfStream is not true)
        {
            var line = process.StandardOutput.ReadLine();
            var property = line.Split(':');
            properties.Add(property[0], property[1]);

        }

        return new ProcessorDetails
        {
            Manufacturer = properties["Vendor ID"].Trim(),
            Name = properties["Model name"].Trim(),
            NumberOfCores = Convert.ToInt32(properties["Core(s) per socket"]),
            NumberOfLogicalProcessors = Convert.ToInt32(properties["CPU(s)"])
        };
    }
}