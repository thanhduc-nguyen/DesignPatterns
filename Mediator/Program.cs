using Mediator;

Console.Title = "Mediator";

var airPlane1 = new AirPlane("Air Plane 1");
var airPlane2 = new AirPlane("Air Plane 2");
var helicopter1 = new Helicopter("Helicopter 1");
var helicopter2 = new Helicopter("Helicopter 2");
var militaryAirCraft1 = new MilitaryAirCraft("Military AirCraft 1");
var militaryAirCraft2 = new MilitaryAirCraft("Military AirCraft 2");

var controlTower = new ControlTower();
controlTower.Register(airPlane1);
controlTower.Register(airPlane2);
controlTower.Register(helicopter1);
controlTower.Register(helicopter2);
controlTower.Register(militaryAirCraft1);
controlTower.Register(militaryAirCraft2);

airPlane1.RequestLaneToTakeOff();
controlTower.Display();

Console.WriteLine("\n");
militaryAirCraft2.RequestLaneToEmergencyTakeOff();
controlTower.Display();