using Bridge;

Console.Title = "Bridge";

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
