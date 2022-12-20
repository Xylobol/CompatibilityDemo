// ReSharper disable CheckNamespace
using System.Reflection;

namespace LibDemo.Sdk.V1_0
{
    public static partial class Api
    {
        public static readonly string RuntimeAssemblyLocation =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}/{Environment.GetEnvironmentVariable("LIBDEMO_ASSEMBLY_NAME")}";

        public static readonly Assembly RuntimeAssembly =
            Assembly.LoadFrom(RuntimeAssemblyLocation);
    }
}

namespace LibDemo.Sdk.V1_1
{
    public static partial class Api
    {
        private static readonly string RuntimeAssemblyLocation = LibDemo.Sdk.V1_0.Api.RuntimeAssemblyLocation;

        private static readonly Assembly RuntimeAssembly = LibDemo.Sdk.V1_0.Api.RuntimeAssembly;
    }
}