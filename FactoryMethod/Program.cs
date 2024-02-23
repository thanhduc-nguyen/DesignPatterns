using FactoryMethod;

Console.Title = "Factory Method";

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
