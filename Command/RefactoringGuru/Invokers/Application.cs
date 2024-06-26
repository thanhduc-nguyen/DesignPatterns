namespace Command.RefactoringGuru.Invokers
{
    public class Application
    {
        List<Commands.Command> commands = new List<Commands.Command>();

        public void SetCommand(Commands.Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand(int slot)
        {
            if (commands[slot].Execute())
            {
                CommandHistory.Instance.History.Push(commands[slot]);
            };
        }

    }
}
