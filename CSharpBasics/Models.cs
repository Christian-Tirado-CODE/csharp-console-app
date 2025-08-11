using System.Security.Cryptography.X509Certificates;

namespace Models;


public class Customer
{
    string Name;
    int Age;

    string Email;

    public Customer(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
}