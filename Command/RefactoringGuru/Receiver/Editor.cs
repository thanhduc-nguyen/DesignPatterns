namespace Command.RefactoringGuru.Receiver
{
    /// <summary>
    /// Receiver.
    /// </summary>
    public class Editor
    {
        public string Text { get; set; } = "Command Pattern is awesome.";

        public string SelectedText { get; set; } = string.Empty;

        public string Clipboard { get; set; } = string.Empty;

        public int PotisionToInsert { get; set; }

        public Editor()
        {
            Console.WriteLine($"Original Text: {Text}");
        }

        public void GetSelection(string selectedText)
        {
            SelectedText = selectedText;
        }

        public void DeleteSelection(string selectedText)
        {
            Text = Text.Replace(selectedText, "");
        }

        public void InsertSelection(string selectedText, int position)
        {
            Text = Text.Insert(position, selectedText);
        }
    }
}
