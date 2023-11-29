using Lab5_c;

internal class Program
{
    private static void Main(string[] args)
    {
        PositionalNumberSystem binarySystem = new PositionalNumberSystem("Binary", 2, "Binary system", 2, true);
        NonPositionalNumberSystem romanSystem = new NonPositionalNumberSystem("Roman", 10, "Roman  system", "X", false);
        MixedNumberSystem mixedSystem = new MixedNumberSystem("Mixed", 16, "Mixed system", "ABC", "I", true);

        NumberSystemCollection systemCollection = new NumberSystemCollection();
        systemCollection.AddSystem(binarySystem);
        systemCollection.AddSystem(romanSystem);
        systemCollection.AddSystem(mixedSystem);

        foreach (var system in systemCollection.Systems)
        {
            Console.WriteLine(system);
        }

        Console.WriteLine("Delete element #2");
        systemCollection.DeleteSystem(1);
        foreach (var system in systemCollection.Systems)
        {
            Console.WriteLine(system);
        }

        Console.WriteLine("Edit element 1");

        binarySystem.NumberOfDigits = 3;

        systemCollection.EditSystem(0, new NonPositionalNumberSystem("Octal", 8, "Base-8 system", "Oct", true));

        foreach (var system in systemCollection.Systems)
        {
            Console.WriteLine(system);
        }

        Console.ReadLine();
    }
}