namespace Command.HeadFirst.Receivers
{
    public class CeilingFan(string location)
    {
        private int _speed = OFF;

        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        public void High()
        {
            _speed = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");
        }

        public void Medium()
        {
            _speed = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void Low()
        {
            _speed = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void Off()
        {
            _speed = OFF;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int GetSpeed() => _speed;
    }
}
