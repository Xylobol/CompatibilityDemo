using LibDemo.Sdk.V1_1;
// ReSharper disable CheckNamespace

namespace LibDemo.Runtime.V1;

public class RuntimeAssemblyInfo : IRuntimeAssemblyInfo
{
    public static void PrintVersion()
    {
        Console.WriteLine("1.1.0");
    }
}