namespace Bridge.HeadFirst
{
    public class SonyTv : ITv
    {
        public void On()
        {
            Console.WriteLine("Sony TV turned on.");
        }

        public void Off()
        {
            Console.WriteLine("Sony TV turned off.");
        }

        public bool TuneChannel(string channel)
        {
            Console.WriteLine($"Sony TV tuning channel: {channel}.");
            return true;
        }
    }
}
