namespace CSharpBasics;

class Program
{
    static void Main(string[] args)
    {

        // Explicit types
        float amount;
        string message = "Hi!";
        string[] names = ["Christian", "Brad", "Tyrone", "Lee", "Carl"];

        // Type inference with the var keyword.
        var namesBeginningWithC = from name in names where name.StartsWith('C') select name;
        Console.WriteLine(string.Join(", ", namesBeginningWithC));


        // Learn more about the IEnumerable interface: https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-9.0

    }
}
