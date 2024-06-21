using Command.HeadFirst.Commands;

namespace Command.HeadFirst.Invokers
{
    public class SimpleRemoteControl
    {
        private ICommand slot;

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonWasPress()
        {
            slot.Execute();
        }
    }
}
