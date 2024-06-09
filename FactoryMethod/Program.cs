using FactoryMethod.HeadFirst.Creators;
using FactoryMethod.RefactoringGuru;

Console.Title = "Factory Method";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var nyStore = new NYPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

var pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var logistics = "Sea";
var roadLogistics = new RoadLogistics();
var seaLogistics = new SeaLogistics();
var transports = new List<ITransport>();

if (logistics == "Road")
{
    for (int i = 0; i < 10; i++)
    {
        transports.Add(roadLogistics.CreateProduct());
    }
}
else
{
    for (int i = 0; i < 10; i++)
    {
        transports.Add(seaLogistics.CreateProduct());
    }
}

transports.ForEach((t) =>
{
    Console.WriteLine($"{t.GetType().Name} {t.GetType().GetProperty("Id")!.GetValue(t)}");
    t.Deliver();
});
