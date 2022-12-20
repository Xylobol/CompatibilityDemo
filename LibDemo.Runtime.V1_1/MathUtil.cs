using LibDemo.Sdk.V1_1;
// ReSharper disable CheckNamespace

namespace LibDemo.Runtime.V1;

public class MathUtil : IMathUtilRuntime
{
    private MathUtil(int x, int y)
    {
        X = x;
        Y = y;
    }

    // treat this like the ctor
    public static IMathUtil Init(int x, int y)
    {
        return new MathUtil(x, y);
    }

    public int X { get; }
    public int Y { get; }

    public int Add() => X + Y;
    public int Multiply() => X * Y;
}