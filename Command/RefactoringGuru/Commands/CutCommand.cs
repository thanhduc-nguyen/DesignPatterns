using Command.RefactoringGuru.Receiver;

namespace Command.RefactoringGuru.Commands
{
    public class CutCommand(Editor editor) : Command(editor)
    {
        public override bool Execute()
        {
            Backup = _editor.Text;
            _editor.Clipboard = _editor.SelectedText;
            _editor.DeleteSelection(_editor.SelectedText);

            Console.WriteLine($"CutCommand - Text: {_editor.Text}");

            return true;
        }
    }
}
