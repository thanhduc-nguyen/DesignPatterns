namespace CompoundPatterns.ObserverPattern
{
    public interface IObserver
    {
        public void Update(IQuackObservable duck);
    }
}
