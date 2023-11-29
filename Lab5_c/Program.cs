using Lab5_c;

internal class Program
{
    private static void Main(string[] args)
    {
        NumberSystem baseSystem1 = new NumberSystem("Name1", 10, "Descr1");
        NumberSystem baseSystem2 = new NumberSystem("Name2", 8, "Descr2");

        PositionalNumberSystem positionalSystem1 = new PositionalNumberSystem("Name3", 2, "Descr3", 2, true);
        PositionalNumberSystem positionalSystem2 = new PositionalNumberSystem("Name4", 10, "Descr4", 10, false);

        NonPositionalNumberSystem nonPositionalSystem1 = new NonPositionalNumberSystem("Name5", 16, "Descr5", "Type1", true);
        NonPositionalNumberSystem nonPositionalSystem2 = new NonPositionalNumberSystem("Name6", 10, "Descr6", "Type2", false);

        MixedNumberSystem mixedSystem1 = new MixedNumberSystem("Name7", 8, "Descr7", "PositionalPart1", "NonPositionalPart1", true);
        MixedNumberSystem mixedSystem2 = new MixedNumberSystem("Name8", 16, "Descr8", "PositionalPart2", "NonPositionalPart2", false);

        Console.WriteLine(baseSystem1.ToString());
        Console.WriteLine(baseSystem2.ToString());

        Console.WriteLine(positionalSystem1.ToString());
        Console.WriteLine(positionalSystem2.ToString());

        Console.WriteLine(nonPositionalSystem1.ToString());
        Console.WriteLine(nonPositionalSystem2.ToString());

        Console.WriteLine(mixedSystem1.ToString());
        Console.WriteLine(mixedSystem2.ToString());
    }
}