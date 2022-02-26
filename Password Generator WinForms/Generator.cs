using System.Security.Cryptography;

internal class Generator
{
    public static string CryptoGenerator(int length, bool isHaveBigLetters, bool isHavePunctuation, bool isHaveNumbers, bool isHaveSmallLetters)
    {
        Random rnd = new();
        string password = "";
        string chars = "";
        if (isHaveNumbers) chars += "1234567890";
        if (isHaveBigLetters) chars += "abcdefghijklmnopqrstuvwxyz".ToUpper();
        if (isHaveSmallLetters) chars += "abcdefghijklmnopqrstuvwxyz";
        if (isHavePunctuation) chars += @"!@#$%^&*()-_+=;:,./?\|`~[]{}";
        for (int i = 0; i < length; i++)
            password += chars[RandomNumberGenerator.GetInt32(chars.Length)];
        return password;
    }
}