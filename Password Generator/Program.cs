class Program
{
    static void Main(string[] args)
    {
        Generator generator = new();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Title = "LittleFoxyUwU - Cryptography Password Generator";
        Console.WriteLine("Welcome to the cryptographic password generator!\n" +
            "Made by Andrew Fox (LittleFoxyUwU) - https://github.com/LittleFoxyUwU!");
        int amount = 0;
        int length = 0;
        bool punctuation = false;
        bool letters = false;
        bool ready = false;
        while (!ready)
        {
            Console.WriteLine("\nHow many passwords you want to generate?");
            amount = int.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Your Amount is zero or negative!");
                continue;
            }

            Console.WriteLine("\nHow long your passwords will be?");
            length = int.Parse(Console.ReadLine());
            if (length <= 0)
            {
                Console.WriteLine("\nYour length is zero or negative!");
                continue;
            }

            Console.WriteLine("\nWill passwords contain letters? y - yes");
            if (Console.ReadLine() is "y")
                letters = true;

            Console.WriteLine("\nWill passwords contain punctuation? y - yes");
            if (Console.ReadLine() is "y")
                punctuation = true;

            Console.WriteLine($"\namount = {amount}\n" +
                $"length = {length}\n" +
                $"Contain letters = {letters}\n" +
                $"Contain puctuation = {punctuation}\n" +
                $"All is right? y - yes");
            if (Console.ReadLine() is "y")
                ready = true;
        }
        for (int i = 0; i < amount; i++)
            Console.WriteLine($"{i + 1}: " + generator.CryptoGenerator(length, letters, punctuation) + "\n");
        Console.WriteLine("Program is done! Press enter to close.");
        Console.ReadLine();
    }
}