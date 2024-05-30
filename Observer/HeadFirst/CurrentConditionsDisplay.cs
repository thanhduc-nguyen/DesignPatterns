namespace Observer.HeadFirst
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private ISubject _weatherData;

        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }
    }
}
