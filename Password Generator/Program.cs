Generator generator = new();
Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "LittleFoxyUwU - Cryptography Password Generator";
Console.WriteLine("Welcome to the cryptographic password generator!\n" +
    "Made by Andrew Fox (LittleFoxyUwU) - https://github.com/LittleFoxyUwU!");
int amount = 0;
int length = 0;
bool ready = false;
while (!ready)
{
    Console.WriteLine("How many passwords you want to generate?");
    amount = int.Parse(Console.ReadLine());
    if (amount <= 0)
    {
        Console.WriteLine("Your Amount is zero or negative!");
        continue;
    }

    Console.WriteLine("How long your passwords will be?");
    length = int.Parse(Console.ReadLine());
    if (length <= 0)
    {
        Console.WriteLine("Your length is zero or negative!");
        continue;
    }

    Console.WriteLine($"amount = {amount}\n" +
        $"length = {length}\n" +
        $"All is right? y - yes");
    if (Console.ReadLine() is "y")
            ready = true;
}
for (int i = 0; i < amount; i++)
    Console.WriteLine(generator.CryptoGenerator(length, true, true) + "\n");