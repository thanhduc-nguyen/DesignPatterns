using TemplateMethod.HeadFirst.DuckSort;
using TemplateMethod.HeadFirst.StarbuzzCoffee;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Template Method";

        Console.WriteLine("Head First Design Pattern");
        Console.WriteLine("=========================\n");

        //StarbuzzCoffee();
        DuckSort();
    }

    private static void StarbuzzCoffee()
    {
        Tea teaHook = new();
        CoffeeWithHook coffeeHook = new();
        Console.WriteLine("\nMaking tea...");
        teaHook.PrepareRecipe();
        Console.WriteLine("\nMaking coffee...");
        coffeeHook.PrepareRecipe();
    }

    public static void DuckSort()
    {
        Duck[] ducks =
        {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

        Console.WriteLine("Before sorting:");
        Display(ducks);

        Array.Sort(ducks);

        Console.WriteLine("\nAfter sorting:");
        Display(ducks);
    }

    public static void Display(IEnumerable<Duck> ducks)
    {
        foreach (var duck in ducks)
        {
            Console.WriteLine(duck);
        }
    }
}
