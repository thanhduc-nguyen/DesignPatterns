// Switch between object adapter and class adapter implementation
//using Adapter.ObjectAdapterImplementation;
using Adapter.ClassAdapterImplementation;

Console.Title = "Adapter";

var adapter = new VietnameseStockAdapter();
var data1 = adapter.GetData();

Console.WriteLine($"=== Stock Information  ===");
foreach (var item in data1)
{
    Console.WriteLine($"{item.Company} - {item.PriceInVnd} VND");
}