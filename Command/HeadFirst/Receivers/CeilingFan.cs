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
        }

        public void Medium()
        {
            _speed = MEDIUM;
        }

        public void Low()
        {
            _speed = LOW;
        }

        public void Off()
        {
            _speed = OFF;
        }

        public int GetSpeed() => _speed;
    }
}
