using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
    {
        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
