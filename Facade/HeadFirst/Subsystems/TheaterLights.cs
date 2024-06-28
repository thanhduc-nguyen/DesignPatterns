namespace Facade.HeadFirst.Subsystems
{
    public class TheaterLights(string description)
    {
        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void Dim(int level)
        {
            Console.WriteLine($"{description} dimming to {level.ToString()}%");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
