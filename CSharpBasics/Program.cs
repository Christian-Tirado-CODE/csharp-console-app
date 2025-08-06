namespace CSharpBasics;

class Program
{
    static void Main(string[] args)
    {
        var employee1 = (id: 1, name: "Christian", department: "IT", age: 60);
        Console.WriteLine($"Hi! My name is {employee1.name}, I'm {employee1.age} years old and I work at the {employee1.department} department.");
        employee1.department = "Human Resources";
        employee1.age = employee1.age + 1;
        Console.WriteLine($"I want to inform you that I just turned {employee1.age}! Also, I moved to the {employee1.department} department.");
        var employee2 = employee1 with { id = 2, name = "Karen" };
        Console.WriteLine($"Hi! My name is {employee2.name}, I'm also {employee2.age} years old and work at the {employee1.department} department.");

        // Tuples have limited capabilities. That's why there are other types that define behavior. 
    }
}
