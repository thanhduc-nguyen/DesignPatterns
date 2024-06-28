using System.Globalization;

namespace Facade.HeadFirst.Subsystems
{
    public class Tuner(string description, Amplifier amplifier)
    {
        private double _frequency;

        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"{description} setting frequency to {frequency.ToString(CultureInfo.InvariantCulture)}");
            _frequency = frequency;
        }

        public void SetAm()
        {
            Console.WriteLine($"{description} setting AM mode");
        }

        public void SetFm()
        {
            Console.WriteLine($"{description} setting FM mode");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
