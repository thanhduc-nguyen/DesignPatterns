using CompoundPatterns.Entities;
using CompoundPatterns.ObserverPattern;

namespace CompoundPatterns.CompositePattern
{
    public class Flock : IQuackable
    {
        private List<IQuackable> _quackers = [];

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            var iterator = _quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = iterator.Current;
                quacker.Quack();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quacker in _quackers)
            {
                quacker.RegisterObserver(observer);
            }

        }

        public void NotifyObservers()
        {
            foreach (var quacker in _quackers)
            {
                quacker.NotifyObservers();
            }
        }
    }
}
