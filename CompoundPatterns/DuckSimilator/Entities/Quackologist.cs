using CompoundPatterns.ObserverPattern;

namespace CompoundPatterns.Entities
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} just quacked.");
        }
    }
}
