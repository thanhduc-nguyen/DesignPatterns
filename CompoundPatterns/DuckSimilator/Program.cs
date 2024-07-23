using CompoundPatterns.AbstractFactoryPattern;
using CompoundPatterns.CompositePattern;
using CompoundPatterns.DecoratorPattern;
using CompoundPatterns.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        AbstractDuckFactory duckFactory = new CountingDuckFactory();
        AbstractGooseFactory gooseFactory = new AdapterGooseFactory();
        new Program().Simulate(duckFactory, gooseFactory);
    }

    void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
    {
        Console.WriteLine("\nDuck Simulator: With Abstract Factory");
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        IQuackable gooseDuck = gooseFactory.CreateGoose();

        Console.WriteLine("\nDuck Simulator: With Composite - Flocks");
        Flock flockOfDucks = new Flock();
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        Flock flockOfMallards = new Flock();
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());

        flockOfDucks.Add(flockOfMallards);

        Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
        Simulate(flockOfDucks);
        Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallards);

        Console.WriteLine("\nDuck Simulator: With Observer");
        Quackologist quackologist = new Quackologist();

        flockOfDucks.RegisterObserver(quackologist);
        Simulate(flockOfDucks);

        Console.WriteLine($"\nThe ducks quacked {QuackCounter.NumberOfQuacks} times.");
    }
    void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}