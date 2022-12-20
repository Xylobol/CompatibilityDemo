// ReSharper disable CheckNamespace
namespace LibDemo.Sdk.V1_0
{
    public static partial class Api
    {
        public static void PrintRuntimeAssemblyVersion()
        {
            var runtimeAssemblyInfoType = RuntimeAssembly.GetType("LibDemo.Runtime.V1.RuntimeAssemblyInfo")!;
            runtimeAssemblyInfoType.GetMethod("PrintVersion")!.Invoke(null, null);
        }
    }

    public interface IRuntimeAssemblyInfo
    {
        static abstract void PrintVersion();
    }
}

namespace LibDemo.Sdk.V1_1
{
    public static partial class Api
    {
        public static void PrintRuntimeAssemblyVersion()
        {
            var runtimeAssemblyInfoType = RuntimeAssembly.GetType("LibDemo.Runtime.V1.RuntimeAssemblyInfo")!;
            runtimeAssemblyInfoType.GetMethod("PrintVersion")!.Invoke(null, null);
        }
    }

    public interface IRuntimeAssemblyInfo : LibDemo.Sdk.V1_0.IRuntimeAssemblyInfo
    {
    }
}