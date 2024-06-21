namespace Command.HeadFirst.Receivers
{
    public class GarageDoor(string location)
    {
        public void Up() => Console.WriteLine(location + " garage Door is Open");

        public void Down() => Console.WriteLine(location + " garage Door is Closed");

        public void Stop() => Console.WriteLine(location + " garage Door is Stopped");

        public void LightOn() => Console.WriteLine(location + " garage light is on");

        public void LightOff() => Console.WriteLine(location + " garage light is off");
    }
}
