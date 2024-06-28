namespace Facade.HeadFirst.Subsystems
{
    public class CdPlayer(string description, Amplifier amplifier)
    {
        private string _title;
        private int _currentTrack;

        public void On()
        {
            Console.WriteLine($"{description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{description} off");
        }

        public void Eject()
        {
            _title = null;
            Console.WriteLine($"{description} eject");
        }

        public void Play(string title)
        {
            _title = title;
            _currentTrack = 0;

            Console.WriteLine($"{description} playing \"{_title}\"");
        }

        public void Play(int track)
        {
            if (_title == null)
            {
                Console.WriteLine($"{description} can't play track {_currentTrack.ToString()}, no cd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine($"{description} playing track {_currentTrack.ToString()}");
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine($"{description} stopped");
        }

        public void Pause()
        {
            Console.WriteLine($"{description} paused \"{_title}\"");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
