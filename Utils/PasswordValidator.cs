using System.Security.Cryptography.X509Certificates;

public static class PasswordValidator
{
    private const string hashKey = "gdhdbkjfme";
    public static bool IsValidPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return false;
        return password.Length >= 6;
    }

    public static string HashedPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Password is invalid");
        return password + hashKey;
    }

}