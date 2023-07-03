using System;
using System.Runtime.InteropServices.JavaScript;

namespace MyCSharpLib.CSharp;

public class CSharp
{
    public readonly int? Number;
    public readonly int BestNumber;

    public CSharp(int? number, int bestNumber)
    {
        (Number, BestNumber) = (number, bestNumber);
    }

    public void PrintNumber()
    {
        if (Number is not null )
        {
            Console.WriteLine("Number is not null {0}", Number.Value);
        }

        if (Number is {} num)
        {
            Console.WriteLine("Number is not null {0}", num);
        }

        if (Number is int num1)
        {
            Console.WriteLine("Number is not null {0}", num1);
        }

        if (Number.HasValue)
        {
            Console.WriteLine("Number is not null {0}", Number.Value);
        }
    }

    public void Deconstruct(out int number, out int bestNumber)
    {
        (number, bestNumber) = (Number ?? 0, BestNumber);

    }

    public int Divide()
    {
        if (BestNumber == 0)
            throw new DivideByZeroException();
        if (Number is null)
            throw new NumberIsNullException($"{nameof(Number)} is null");

        return Number.Value/BestNumber;
    }
}

public static class CSharpExtensions{
    public static bool AreNumberEqual(this CSharp x) => x.Number.HasValue && x.Number.Value == x.BestNumber;
}

public class NumberIsNullException : Exception
{
    public NumberIsNullException() : base(){}
    public NumberIsNullException(string message) : base(message) { }
}