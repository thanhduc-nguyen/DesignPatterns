using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class GarageDoorDownCommand(GarageDoor garageDoor) : ICommand
    {
        public void Execute()
        {
            garageDoor.Down();
        }
    }
}
