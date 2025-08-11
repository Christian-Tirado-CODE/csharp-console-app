namespace Utilities;


public class InputValidator
{
    public static bool IsValidEmail(string email)
    {
        return email.Contains("@");
    }
}