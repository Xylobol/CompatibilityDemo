# CompatibilityDemo
demo of how you can guarantee binary and source compatibility in .NET for the funny systems engineering group

## Try the demo

Make sure you've got the .NET 7 SDK installed. This could target .NET Standard 2.1 as well, but I used 7 for some quality-of-life features.

1. Build the `LibDemo.Runtime.V1_0` and `LibDemo.Runtime.V1_1` projects.
    - `cd LibDemo.whatever`
    - `dotnet build`
2. Copy the built assemblies/DLLs from the output.
    - Only copy the ones starting with `LibDemo.Runtime.V1`
    - Put them in your home folder
3. Run ConsoleApp1
    - `cd ConsoleApp1`
    - `dotnet run`
4. Try changing between lines 4 and 5 in ConsoleApp1 to see how it handles having a newer runtime than SDK

For bonus points, try creating your own minor and major releases of the library. Semver rules apply - the major releases can break binary/source compatibility.

## How it works

.NET can load [Assemblies](https://learn.microsoft.com/en-us/dotnet/standard/assembly/) at runtime from any given file. This solution creates an SDK library, `LibDemo.Sdk`, that has multiple namespaces, representing API versions. Our minor version, `LibDemo.Sdk.V1_1`, mixes-in the interfaces defined in the v1.0 to ensure compatibility. The SDK library also includes a static class consisting of helper methods to load the assembly, call methods, and instantiate classes.

Because .NET assemblies contain full types, and the SDK library makes sure the types are compatible, you can still use `LibDemo.Sdk.V1_0.Api` with `LibDemo.Runtime.V1_1.dll`.