namespace CompoundPatterns.ObserverPattern
{
    public class Observable(IQuackObservable duck) : IQuackObservable
    {
        private List<IObserver> _observers = [];

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            var iterator = _observers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IObserver observer = iterator.Current;
                observer.Update(duck);
            }
        }
    }
}
