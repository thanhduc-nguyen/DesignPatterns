namespace Bridge.HeadFirst
{
    public class RcaTv : ITv
    {
        public void On()
        {
            Console.WriteLine("RCA TV turned on.");
        }

        public void Off()
        {
            Console.WriteLine("RCA TV turned off.");
        }

        public bool TuneChannel(string channel)
        {
            Console.WriteLine($"RCA TV tuning channel: {channel}.");
            return true;
        }
    }
}
