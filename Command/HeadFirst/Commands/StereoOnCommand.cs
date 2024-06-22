using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class StereoOnCommand(Stereo stereo) : ICommand
    {
        public void Execute()
        {
            stereo.On();
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
