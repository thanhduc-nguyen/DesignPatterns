namespace Command.HeadFirst.Commands
{
    public class MacroCommand(ICommand[] commands) : ICommand
    {
        private ICommand[] _commands = commands;

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}
