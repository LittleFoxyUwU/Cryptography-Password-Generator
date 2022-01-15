using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

internal class Generator
{
    public string CryptoGenerator(int length, bool isHaveLetters, bool isHavePunctuation)
    {
        Random rnd = new();
        string password = "";
        for (int i = 0; i < length; i++)
        {
            if (!(isHaveLetters || isHavePunctuation))
                password += GenerateNumberCrypto();
            else if (isHaveLetters && !isHavePunctuation)
            {
                switch (rnd.NextInt64(0, 3))
                {
                    case 0: password += GenerateNumberCrypto(); break;
                    case 1: password += GenerateLetterLowerCaseCrypto(); break;
                    case 2: password += GenerateLetterUpperCaseCrypto(); break;
                }
            }
            else
            {
                switch (rnd.NextInt64(0, 4))
                {
                    case 0: password += GenerateNumberCrypto(); break;
                    case 1: password += GenerateLetterLowerCaseCrypto(); break;
                    case 2: password += GenerateLetterUpperCaseCrypto(); break;
                    case 3: password += GenerateSignCrypto(); break;
                }
            }
        }
        return password;
    }
    private char GenerateNumberCrypto()
    {
        string chars = "0123456789";
        char result = chars[RandomNumberGenerator.GetInt32(chars.Length)];
        return result;
    }

    private char GenerateLetterLowerCaseCrypto()
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        char result = chars[RandomNumberGenerator.GetInt32(chars.Length)];
        return result;
    }
    private char GenerateLetterUpperCaseCrypto()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char result = chars[RandomNumberGenerator.GetInt32(chars.Length)];
        return result;
    }

    private char GenerateSignCrypto()
    {
        string chars = "!@#$%^&*()-_+=;:,./?\\|`~[]{}";
        char result = chars[RandomNumberGenerator.GetInt32(chars.Length)];
        return result;
    }
}
