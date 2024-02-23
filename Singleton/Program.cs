using Singleton;

Console.Title = "Singleton";

var db = Database.Instance;
var result = db.Query("SELECT * FROM something");
Console.WriteLine(result);