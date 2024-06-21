using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class CeilingFanOffCommand(CeilingFan ceilingFan) : ICommand
    {
        public void Execute()
        {
            ceilingFan.Off();
        }
    }
}
