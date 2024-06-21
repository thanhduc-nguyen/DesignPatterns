using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class StereoOffCommand(Stereo stereo) : ICommand
    {
        public void Execute()
        {
            stereo.Off();
        }
    }
}
