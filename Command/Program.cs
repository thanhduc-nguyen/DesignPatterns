using Command.HeadFirst.Commands;
using Command.HeadFirst.Invokers;
using Command.HeadFirst.Receivers;
using Command.RefactoringGuru.Commands;
using Command.RefactoringGuru.Invokers;
using Command.RefactoringGuru.Receiver;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Command";

        Console.WriteLine("Head First Design Pattern");
        Console.WriteLine("=========================\n");

        // RunSimpleRemoteControl();

        // RunRemoteControl();

        // RunRemoteControlWithUndo();

        // RunRemoteControlWithUndo2();

        RunRemoteControlWithPartyMode();

        Console.WriteLine();
        Console.WriteLine("Refactoring Guru");
        Console.WriteLine("================\n");

        Application application = new();
        Editor editor = new();
        application.SetCommand(new CopyCommand(editor));
        application.SetCommand(new CutCommand(editor));
        application.SetCommand(new PasteCommand(editor));
        application.SetCommand(new UndoCommand(editor));

        editor.GetSelection("Pattern");
        application.ExecuteCommand(1);
        application.ExecuteCommand(3);
        editor.GetSelection("awesome");
        application.ExecuteCommand(1);
        editor.PotisionToInsert = 0;
        application.ExecuteCommand(2);
        application.ExecuteCommand(3);
        application.ExecuteCommand(3);
    }

    private static void RunSimpleRemoteControl()
    {
        var simpleRemoteControl = new SimpleRemoteControl();
        Light light = new("");
        GarageDoor garageDoor = new("");
        simpleRemoteControl.SetCommand(new LightOnCommand(light));
        simpleRemoteControl.ButtonWasPress();
        simpleRemoteControl.SetCommand(new GarageDoorUpCommand(garageDoor));
        simpleRemoteControl.ButtonWasPress();
    }

    private static void RunRemoteControl()
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

    private static void RunRemoteControlWithUndo()
    {
        RemoteControlWithUndo remoteControl = new();
        Light livingRoomLight = new("Living Room");
        LightOnCommand livingRoomLightOn = new(livingRoomLight);
        LightOffCommand livingRoomLightOff = new(livingRoomLight);

        remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remoteControl.OnButtonWasPushed(0);
        remoteControl.OffButtonWasPushed(0);

        Console.WriteLine(remoteControl);

        remoteControl.UndoButtonWasPushed();
        remoteControl.OffButtonWasPushed(0);
        remoteControl.OnButtonWasPushed(0);

        Console.WriteLine(remoteControl);
        remoteControl.UndoButtonWasPushed();
    }

    private static void RunRemoteControlWithUndo2()
    {
        RemoteControlWithUndo remoteControl = new();
        CeilingFan ceilingFan = new("Living Room");
        CeilingFanMediumCommand ceilingFanMedium = new(ceilingFan);
        CeilingFanHighCommand ceilingFanHigh = new(ceilingFan);
        CeilingFanOffCommand ceilingFanOff = new(ceilingFan);

        remoteControl.SetCommand(0, ceilingFanMedium, ceilingFanOff);
        remoteControl.SetCommand(1, ceilingFanHigh, ceilingFanOff);
        remoteControl.OnButtonWasPushed(0);
        remoteControl.OffButtonWasPushed(0);

        Console.WriteLine(remoteControl);

        remoteControl.UndoButtonWasPushed();
        remoteControl.OnButtonWasPushed(1);

        Console.WriteLine(remoteControl);

        remoteControl.UndoButtonWasPushed();
    }

    private static void RunRemoteControlWithPartyMode()
    {
        Light light = new("Living Room");
        TV tv = new("Living Room");
        Stereo stereo = new("Living Room");
        Hottub hottub = new();

        LightOnCommand lightOn = new(light);
        StereoOnCommand stereoOn = new(stereo);
        TVOnCommand tvOn = new(tv);
        HottubOnCommand hottubOn = new(hottub);

        LightOffCommand lightOff = new(light);
        StereoOffCommand stereoOff = new(stereo);
        TVOffCommand hottubOff = new(tv);
        HottubOffCommand tvOff = new(hottub);

        ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
        ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };
        MacroCommand partyOnMacro = new(partyOn);
        MacroCommand partyOffMacro = new(partyOff);

        RemoteControlWithUndo remoteControl = new();
        remoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

        Console.WriteLine(remoteControl);
        Console.WriteLine("\n---Pushing Macro On---");
        remoteControl.OnButtonWasPushed(0);
        Console.WriteLine("\n---Pushing Macro Off---");
        remoteControl.OffButtonWasPushed(0);
        Console.WriteLine("\n---Pushing Undo---");
        remoteControl.UndoButtonWasPushed();
    }
}
