using Observer.HeadFirst;
using Observer.RefactoringGuru;

Console.Title = "Observer";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var weatherData = new WeatherData();

var currentDisplay = new CurrentConditionsDisplay(weatherData);
var statisticsDisplay = new StatisticsDisplay(weatherData);
var forecastDisplay = new ForecastDisplay(weatherData);
var heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var store = new Store(new BroadcastManager());

var sms = new Sms();
var email = new Email();
var television = new Television();

Console.WriteLine("Add sms, email subscriber for New Phone Event and");
Console.WriteLine("Add sms, email, television subscriber for New Laptop Event");
store.broadcastManager.Subscribe("phone", sms);
store.broadcastManager.Subscribe("phone", email);
store.broadcastManager.Subscribe("laptop", sms);
store.broadcastManager.Subscribe("laptop", email);
store.broadcastManager.Subscribe("laptop", television);

store.IntroduceNewPhone();
store.IntroduceNewLaptop();

Console.WriteLine("\nRemove sms subscriber for New Phone Event");
store.broadcastManager.Unsubscribe("phone", sms);
store.IntroduceNewPhone();
