using Command.RefactoringGuru.Receiver;

namespace Command.RefactoringGuru.Commands
{
    public class PasteCommand(Editor editor) : Command(editor)
    {
        public override bool Execute()
        {
            Backup = _editor.Text;
            _editor.InsertSelection(_editor.Clipboard, _editor.PotisionToInsert);
            _editor.SelectedText = string.Empty;

            Console.WriteLine($"PasteCommand - Text: {_editor.Text}");

            return true;
        }
    }
}
