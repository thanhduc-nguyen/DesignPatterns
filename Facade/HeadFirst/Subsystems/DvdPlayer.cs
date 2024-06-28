namespace Facade.HeadFirst.Subsystems
{
    public class DvdPlayer(string description, Amplifier amplifier)
    {
        private string _movie;
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
            _movie = null;
            Console.WriteLine($"{description} eject");
        }

        public void Play(string movie)
        {
            _movie = movie;
            _currentTrack = 0;

            Console.WriteLine($"{description} playing \"{_movie}\"");
        }

        public void Play(int track)
        {
            if (_movie == null)
            {
                Console.WriteLine($"{description} can't play track {_currentTrack.ToString()}, no dvd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine($"{description} playing track {_currentTrack.ToString()} of \"{_movie}\"");
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine($"{description} stopped \"{_movie}\"");
        }

        public void Pause()
        {
            Console.WriteLine($"{description} paused \"{_movie}\"");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine($"{description} set two channel audio");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine($"{description} set surround audio");
        }

        public override string ToString()
        {
            return description;
        }
    }
}
