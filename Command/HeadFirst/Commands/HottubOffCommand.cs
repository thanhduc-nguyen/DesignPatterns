using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class HottubOffCommand(Hottub hottub) : ICommand
    {
        public void Execute()
        {
            hottub.SetTemperature(98);
            hottub.Off();
        }

        public void Undo()
        {
            hottub.On();
            hottub.SetTemperature(104);
            hottub.Circulate();
        }
    }
}
