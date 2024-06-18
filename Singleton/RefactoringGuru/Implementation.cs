namespace Singleton.RefactoringGuru
{
    public class Database
    {
        private static readonly Lazy<Database> _instance = new Lazy<Database>(() => new Database());

        private Database()
        {
        }

        public static Database Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public string Query(string query)
        {
            return "Data";
        }
    }
}
