using Observer;

Console.Title = "Observer";

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
