using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class GarageDoorUpCommand(GarageDoor garageDoor) : ICommand
    {
        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
