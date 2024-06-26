using Command.RefactoringGuru.Receiver;

namespace Command.RefactoringGuru.Commands
{
    public class CopyCommand(Editor editor) : Command(editor)
    {
        public override bool Execute()
        {
            _editor.Clipboard = _editor.SelectedText;

            Console.WriteLine($"CopyCommand - Text: {_editor.Text}");

            return false;
        }
    }
}
