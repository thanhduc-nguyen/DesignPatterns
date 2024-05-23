using Strategy.HeadFirst;
using Strategy.RefactoringGuru;

Console.Title = "Strategy";

Console.WriteLine("Head First Design Pattern");
Console.WriteLine("=========================\n");

var mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

var model = new ModelDuck(new Quack(), new FlyNoWay());
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();

Console.WriteLine();
Console.WriteLine("Refactoring Guru");
Console.WriteLine("================\n");

var navigator = new Navigator();
navigator.SetStrategy(new CarStrategy());
navigator.BuildRoute("Lang Bac", "Ho Hoan Kiem");