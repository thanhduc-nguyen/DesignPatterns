using AbstractFactory;

Console.Title = "Abstract Factory";

void ClientMethod(IFurnitureFactory furnitureFactory)
{
    var mordenChair = furnitureFactory.CreateChair();
    mordenChair.HasLegs();

    var modernCoffeeTable = furnitureFactory.CreateCoffeeTable();
    modernCoffeeTable.SitOn();
}


ClientMethod(new ModernFurnitureFactory());