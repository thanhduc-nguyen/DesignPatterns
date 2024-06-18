using Singleton.HeadFirst;
using Singleton.RefactoringGuru;

Console.Title = "Singleton";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

ChocolateBoiler boiler = ChocolateBoiler.Instance;
boiler.Fill();
Console.WriteLine($"After Fill(): Empty: {boiler.Empty} - Boiled: {boiler.Boiled}");
boiler.Boil();
Console.WriteLine($"After Boil(): Empty: {boiler.Empty} - Boiled: {boiler.Boiled}");
boiler.Drain();
Console.WriteLine($"After Drain(): Empty: {boiler.Empty} - Boiled: {boiler.Boiled}");

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var db = Database.Instance;
var result = db.Query("SELECT * FROM something");
Console.WriteLine(result);