using Command.HeadFirst.Commands;
using Command.HeadFirst.Invokers;
using Command.HeadFirst.Receivers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Command";

        Console.WriteLine("Head First Design Pattern");
        Console.WriteLine("=========================\n");

        // SimpleRemoteControl();

        // RemoteControl();

        //Console.WriteLine();
        //Console.WriteLine("Refactoring Guru");
        //Console.WriteLine("================\n");

    }

    private static void SimpleRemoteControl()
    {
        var simpleRemoteControl = new SimpleRemoteControl();
        Light light = new("");
        GarageDoor garageDoor = new("");
        simpleRemoteControl.SetCommand(new LightOnCommand(light));
        simpleRemoteControl.ButtonWasPress();
        simpleRemoteControl.SetCommand(new GarageDoorUpCommand(garageDoor));
        simpleRemoteControl.ButtonWasPress();
    }

    private static void RemoteControl()
    {
        RemoteControl remoteControl = new();
        Light livingRoomLight = new("Living Room");
        Light kitchenLight = new("Kitchen");
        CeilingFan ceilingFan = new("Living Room");
        GarageDoor garageDoor = new("");
        Stereo stereo = new("Living Room");
        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);
        LightOnCommand kitchenLightOn = new(kitchenLight);
        LightOffCommand kitchenLightOff = new(kitchenLight);
        CeilingFanOnCommand ceilingFanOn = new(ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new(ceilingFan);
        GarageDoorUpCommand garageDoorUp = new(garageDoor);
        GarageDoorDownCommand garageDoorDown = new(garageDoor);
        StereoOnWithCDCommand stereoOnWithCD = new(stereo);
        StereoOffCommand stereoOff = new(stereo);

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
        remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
        Console.WriteLine(remoteControl);
        remoteControl.OnButtonWasPushed(0);
        remoteControl.OffButtonWasPushed(0);
        remoteControl.OnButtonWasPushed(1);
        remoteControl.OffButtonWasPushed(1);
        remoteControl.OnButtonWasPushed(2);
        remoteControl.OffButtonWasPushed(2);
        remoteControl.OnButtonWasPushed(3);
        remoteControl.OffButtonWasPushed(3);
    }
}
