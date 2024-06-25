// Switch between object adapter and class adapter implementation
//using Adapter.RefactoringGuru.ObjectAdapterImplementation;
using Adapter.HeadFirst;
using Adapter.RefactoringGuru.ClassAdapterImplementation;

Console.Title = "Adapter";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

MallardDuck duck = new();
WildTurkey turkey = new();
IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says...");
turkey.Gobble();
turkey.Fly();

Console.WriteLine("\nThe Duck says...");
TestDuck(duck);

Console.WriteLine("\nThe TurkeyAdapter says...");
TestDuck(turkeyAdapter);

Console.WriteLine("\nThe DuckAdapter says...");
ITurkey duckAdapter = new DuckAdapter(duck);
TestTurkey(duckAdapter);

static void TestDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}

static void TestTurkey(ITurkey turkey)
{
    turkey.Gobble();
    turkey.Fly();
}

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var adapter = new VietnameseStockAdapter();
var data1 = adapter.GetData();

Console.WriteLine($"=== Stock Information  ===");
foreach (var item in data1)
{
    Console.WriteLine($"{item.Company} - {item.PriceInVnd} VND");
}