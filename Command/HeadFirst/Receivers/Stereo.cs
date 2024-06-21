namespace Command.HeadFirst.Receivers
{
    public class Stereo(string location)
    {
        public void On() => Console.WriteLine(location + " stereo is on");

        public void Off() => Console.WriteLine(location + " stereo is off");

        public void SetCD() => Console.WriteLine(location + " stereo is set for CD input");

        public void SetDVD() => Console.WriteLine(location + " stereo is set for DVD input");

        public void SetRadio() => Console.WriteLine(location + " stereo is set for Radio");

        public void SetVolume(int volume) => Console.WriteLine(location + " stereo volume set to " + volume);
    }
}
