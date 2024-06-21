using Command.HeadFirst.Commands;
using Command.HeadFirst.Invokers;
using Command.HeadFirst.Receivers;

Console.Title = "Command";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var simpleRemoteControl = new SimpleRemoteControl();
Light light = new();
GarageDoor garageDoor = new();
simpleRemoteControl.SetCommand(new LightOnCommand(light));
simpleRemoteControl.ButtonWasPress();
simpleRemoteControl.SetCommand(new GarageDoorOpenCommand(garageDoor));
simpleRemoteControl.ButtonWasPress();

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

