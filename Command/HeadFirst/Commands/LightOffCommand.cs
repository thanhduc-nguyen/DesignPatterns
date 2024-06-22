using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class LightOffCommand(Light light) : ICommand
    {
        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
