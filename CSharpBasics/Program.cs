namespace CSharpBasics;
public record FinancialTransaction(
        DateTime TransactionDate,
        string Description,
        decimal Amount,
        string Currency,
        string TransactionType
    )
    {
        public void PrintTransaction() => Console.WriteLine($"Transaction Info: Date {TransactionDate}, Description {Description}, Amount {Amount} {Currency}, Type of Transaction {TransactionType}");
    };

class Program
{

    static void Main(string[] args)
    {
        FinancialTransaction ft = new FinancialTransaction(DateTime.Now, "low-key transfer ;)", 100.00M, "USD", "Transfer");

        ft.PrintTransaction();
    }
    //custom types: record, struct, class, interface and enum.
    // Keep in mind the difference between a class and a struct.
     /*
        Additional resources:
        - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
        - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/records
        - https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes

     */
}
