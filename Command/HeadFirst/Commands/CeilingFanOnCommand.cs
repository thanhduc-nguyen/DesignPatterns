using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class CeilingFanOnCommand(CeilingFan ceilingFan) : ICommand
    {
        public void Execute()
        {
            ceilingFan.High();
        }

        public void Undo()
        {
            ceilingFan.Off();
        }
    }
}
