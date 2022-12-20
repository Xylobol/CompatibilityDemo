// ReSharper disable CheckNamespace
namespace LibDemo.Sdk.V1_0
{
    public static partial class Api
    {
        public static IMathUtil MathUtil(int x, int y)
        {
            var mathUtilType = RuntimeAssembly.GetType("LibDemo.Runtime.V1.MathUtil")!;
            var info = mathUtilType.GetMethod("Init")!;
            return (info.Invoke(null, new object?[]{ x, y }) as IMathUtil)!;
        }
    }

    // adds extra bits for the Runtime that shouldn't be exposed to anything except the loader
    public interface IMathUtilRuntime : IMathUtil
    {
        static abstract IMathUtil Init(int x, int y); // we need this for loading
    }
    
    public interface IMathUtil
    {
        int X { get; }
        int Y { get; }
        int Add();
    }
}

namespace LibDemo.Sdk.V1_1
{
    public static partial class Api
    {
        public static IMathUtil MathUtil(int x, int y)
        {
            var mathUtilType = RuntimeAssembly.GetType("LibDemo.Runtime.V1.MathUtil")!;
            var info = mathUtilType.GetMethod("Init")!;
            return (info.Invoke(null, new object?[]{ x, y }) as IMathUtil)!;
        }
    }
    
    public interface IMathUtilRuntime : IMathUtil
    {
        static abstract IMathUtil Init(int x, int y);
    }
    
    public interface IMathUtil : LibDemo.Sdk.V1_0.IMathUtil
    {
        int Multiply();
    }
}