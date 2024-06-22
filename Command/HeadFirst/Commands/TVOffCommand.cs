using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class TVOffCommand(TV tv) : ICommand
    {
        public void Execute()
        {
            tv.Off();
        }

        public void Undo()
        {
            tv.On();
        }
    }
}
