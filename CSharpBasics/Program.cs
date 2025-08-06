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
    }
}
