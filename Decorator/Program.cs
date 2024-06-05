using Decorator.HeadFirst;

Console.Title = "Decorator";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var beverage = new Espresso();
Console.WriteLine($"{beverage.Description} ${beverage.Cost()}");

var beverage2 = new DarkRoast() as Beverage;
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine($"{beverage2.Description} ${beverage2.Cost()}");

Beverage beverage3 = new HouseBlend();
beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine($"{beverage3.Description} ${beverage3.Cost()}");