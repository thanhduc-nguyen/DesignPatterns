using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class TVOnCommand(TV tv) : ICommand
    {
        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}
