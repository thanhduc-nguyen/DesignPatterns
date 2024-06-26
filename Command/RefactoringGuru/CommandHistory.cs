namespace Command.RefactoringGuru
{
    public class CommandHistory
    {
        private static readonly Lazy<CommandHistory> _instance = new(() => new CommandHistory());

        private CommandHistory()
        {
        }

        public static CommandHistory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public Stack<Commands.Command> History { get; set; } = new Stack<Commands.Command>();
    }
}
