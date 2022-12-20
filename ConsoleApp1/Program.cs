using static LibDemo.Sdk.V1_0.Api;

// choose the runtime assembly you're using
Environment.SetEnvironmentVariable("LIBDEMO_ASSEMBLY_NAME", "LibDemo.Runtime.V1_0.dll");
// Environment.SetEnvironmentVariable("LIBDEMO_ASSEMBLY_NAME", "LibDemo.Runtime.V1_1.dll");

Console.WriteLine("hy :)");

PrintRuntimeAssemblyVersion();

var mathUtil = MathUtil(500, 36);
Console.WriteLine(mathUtil.Add());
