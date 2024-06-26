using Command.RefactoringGuru.Receiver;

namespace Command.RefactoringGuru.Commands
{
    public class UndoCommand(Editor editor) : Command(editor)
    {
        public override bool Execute()
        {
            CommandHistory.Instance.History.Pop().Undo();

            Console.WriteLine($"UndoCommand - Text: {_editor.Text}");

            return false;
        }
    }
}
