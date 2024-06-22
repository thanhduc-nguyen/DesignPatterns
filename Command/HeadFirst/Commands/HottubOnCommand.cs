using Command.HeadFirst.Receivers;

namespace Command.HeadFirst.Commands
{
    public class HottubOnCommand(Hottub hottub) : ICommand
    {
        public void Execute()
        {
            hottub.On();
            hottub.SetTemperature(104);
            hottub.Circulate();
        }

        public void Undo()
        {
            hottub.Off();
        }
    }
}
