namespace CSharpBasics;

using Models;
using Utilities;

class Program
{
    static void Main(string[] args)
    {
        string email = "johnsmith@gmail.com";
        if (InputValidator.IsValidEmail(email))
        {
            Customer c = new Customer("John Smith", 42, email);
            Console.WriteLine("Customer was created!");
        }
        else
        {
            Console.WriteLine("Write a valid email.");
        }

    }
}
