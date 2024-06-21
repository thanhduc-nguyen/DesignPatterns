namespace Command.HeadFirst.Receivers
{
    public class Light(string location)
    {
        public void On() => Console.WriteLine(location + " light is on");

        public void Off() => Console.WriteLine(location + " light is off");
    }
}
