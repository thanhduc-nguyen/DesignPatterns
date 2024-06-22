namespace Command.HeadFirst.Commands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
