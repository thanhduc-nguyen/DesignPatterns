using AbstractFactory;
using AbstractFactory.HeadFirst.Creators;

Console.Title = "Abstract Factory";

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

void ClientMethod(IFurnitureFactory furnitureFactory)
{
    var mordenChair = furnitureFactory.CreateChair();
    mordenChair.HasLegs();

    var modernCoffeeTable = furnitureFactory.CreateCoffeeTable();
    modernCoffeeTable.SitOn();
}


ClientMethod(new ModernFurnitureFactory());