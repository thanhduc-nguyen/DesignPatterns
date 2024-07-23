namespace CompoundPatterns.ObserverPattern
{
    public interface IQuackObservable
    {
        public void RegisterObserver(IObserver observer);
        public void NotifyObservers();
    }
}
