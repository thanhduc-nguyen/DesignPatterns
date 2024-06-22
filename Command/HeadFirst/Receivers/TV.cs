namespace Command.HeadFirst.Receivers
{
    public class TV(string location)
    {
        private int _channel;

        public void On() => Console.WriteLine(location + " TV is on");

        public void Off() => Console.WriteLine(location + " TV is off");

        public void SetInputChannel()
        {
            _channel = 3;
            Console.WriteLine(location + " TV channel is set for DVD");
        }
    }
}
