using State.HeadFirst;
using State.RefactoringGuru;

Console.Title = "State";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

GumballMachine gumballMachine = new GumballMachine(5);

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

Console.WriteLine(gumballMachine);

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

Document document = new Document();
document.PublishedByUser();
document.RejectedByAdmin();

Console.WriteLine(document.State.ToString());

document.PublishedByAdmin();

Console.WriteLine(document.State.ToString());

document.BackToDraft();
document.PublishedByUser();
document.ApprovedByAdmin();

Console.WriteLine(document.State.ToString());