using Bridge.HeadFirst;
using Bridge.RefactoringGuru;

Console.Title = "Bridge";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var rcaTv = new RcaTv();
var sonyTv = new SonyTv();

var firstGenRcaRemote = new FirstGenerationRemoteControl(rcaTv);
var secondGenSonyRemote = new SecondGenerationRemoteControl(sonyTv);
firstGenRcaRemote.SetCurrentChannel(0);
firstGenRcaRemote.SetUpChannel("Disney Channel");

Console.WriteLine("Check channel list");
foreach (var channel in firstGenRcaRemote.Channels)
{
    Console.WriteLine($"Number {channel.Key}: {channel.Value}");
}

firstGenRcaRemote.TurnOn();
firstGenRcaRemote.TurnOff();

secondGenSonyRemote.TurnOn();
secondGenSonyRemote.TurnOffByTime(5000);

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var redColor = new RedColor();
var blueColor = new BlueColor();

var redCircle = new Circle(redColor);
redCircle.Paint();
Console.WriteLine($"redCircle is the {redCircle.GetType().Name} which is {redCircle.Color}");

var redSquare = new Square(redColor);
redSquare.Paint();
Console.WriteLine($"redSquare is the {redSquare.GetType().Name} which is {redSquare.Color}");

var blueCircle = new Circle(blueColor);
blueCircle.Paint();
Console.WriteLine($"blueCircle is the {blueCircle.GetType().Name} which is {blueCircle.Color}");

var blueSquare = new Circle(blueColor);
blueSquare.Paint();
Console.WriteLine($"blueSquare is the {blueSquare.GetType().Name} which is {blueSquare.Color}");
