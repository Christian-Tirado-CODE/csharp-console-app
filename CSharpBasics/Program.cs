namespace CSharpBasics;

class Program
{
    static void Main(string[] args)
    {
        int intMin = int.MinValue;
        int intMax = int.MaxValue;
        Console.WriteLine($"The range of integers is between {intMin} and {intMax}");
        Console.WriteLine($"If we add one to the max value it will cause an overflow condition so {intMax} plus one is {intMax + 1}.");
        Console.WriteLine($"Subtracting one from the min value causes an underflow condition so {intMin} minus one is {intMin - 1}.");


        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Console.WriteLine($"The range of double value is between {doubleMin} and {doubleMax}.");

        // Be mindful of rounding errors. It can lead inaccurate outputs which have significant impact in financial and scientific applications.
        // https://www.cs.drexel.edu/~popyack/Courses/CSP/Fa17/extras/Rounding/index.html

        decimal decimalMax = decimal.MaxValue;
        decimal decimalMin = decimal.MinValue;

        Console.WriteLine($"The range of the decimal type is from {decimalMin} to {decimalMax}.");

        double a = 1.0;
        double b = 3.0;
        decimal c = 1.0M;
        decimal d = 3.0M;
        Console.WriteLine("Notice the difference in precision between the double and decimal type.");
        Console.WriteLine("Double: " + a / b);
        Console.WriteLine("Decimal: " + c / d);
        /*
        Additional resources:
        - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
        - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
        
        */
    }
}
