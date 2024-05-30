namespace Observer.HeadFirst
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
