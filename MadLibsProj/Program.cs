// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provide a verb");
        var verb = Console.ReadLine();

        Console.WriteLine("Provide a noun");
        var noun = Console.ReadLine();

        Console.WriteLine("Pick a number between 1-10.");
        var number = Console.ReadLine();

        Console.WriteLine($"I went for a {verb}. When I saw a {noun}, " +
            $"and I couldn't believe my eyes. They had {number} chickens in their pocket.");
    }
    
}

