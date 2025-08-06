namespace CSharpBasics;

class Program
{
    static void Main(string[] args)
    {
        string myName = "Christian";
        string myMothersName = "Mary";
        string greeting = $"Hi! My name is {myName}! My Mother's name is {myMothersName} and it obviously consists of {myMothersName.Length} letters.         ";
        string trimmedGreeting = greeting.Trim();
        string askForWater = "If you want to ask for water in spanish then you can say the following: Can I please have some water?";
        string askForWaterESTranslation = askForWater.Replace("Can I please have some water?", "Por favor me puedes traer agua?");
        Console.WriteLine("Greeting: " + trimmedGreeting);
        Console.WriteLine("Translation:" + askForWaterESTranslation);
        Console.WriteLine("Does the askForWaterESTranslation variable have the word 'agua'?: " + askForWaterESTranslation.Contains("agua"));
    }
}
