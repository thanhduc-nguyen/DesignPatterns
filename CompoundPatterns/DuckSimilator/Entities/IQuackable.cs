using CompoundPatterns.ObserverPattern;

namespace CompoundPatterns.Entities
{
    public interface IQuackable : IQuackObservable
    {
        public void Quack();
    }
}
