using Command.RefactoringGuru.Receiver;

namespace Command.RefactoringGuru.Commands
{
    /// <summary>
    /// Abstract command.
    /// </summary>
    /// <param name="editor"></param>
    public abstract class Command(Editor editor)
    {
        protected readonly Editor _editor = editor;

        protected string Backup { private get; set; } = string.Empty;

        public abstract bool Execute();

        public void Undo()
        {
            _editor.Text = Backup;
        }
    }
}