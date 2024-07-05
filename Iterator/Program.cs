using Iterator.HeadFirst;

Console.Title = "Iterator";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

Waitress waitress = new(new PancakeHouseMenu(), new DinerMenu());
waitress.PrintMenu();