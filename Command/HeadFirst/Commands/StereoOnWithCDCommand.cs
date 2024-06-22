using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class StereoOnWithCDCommand(Stereo stereo) : ICommand
    {
        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
