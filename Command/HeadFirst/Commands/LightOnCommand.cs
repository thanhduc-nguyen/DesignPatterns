using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class LightOnCommand(Light light) : ICommand
    {
        public void Execute()
        {
            light.On();
        }
    }
}
