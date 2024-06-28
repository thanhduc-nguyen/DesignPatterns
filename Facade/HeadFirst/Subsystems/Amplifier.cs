namespace Facade.HeadFirst.Subsystems
{
    public class Amplifier(string description)
    {
        public Tuner Tuner { get; private set; }
        public DvdPlayer Dvd { get; private set; }
        public CdPlayer Cd { get; private set; }

        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine($"{description} stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{description} surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{description} setting volume to {level.ToString()}");
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine($"{description} setting tunner to {tuner}");
            Tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine($"{description} setting DVD player to {dvd}");
            Dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine($"{description} setting CD player to {cd}");
            Cd = cd;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
