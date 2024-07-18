namespace State.RefactoringGuru
{
    public class PublishedState(Document document) : IState
    {
        public void UserPublish()
        {
            Console.WriteLine("UserPublish(): Still in Published");
        }

        public void AdminPubish()
        {
            Console.WriteLine("AdminPubish(): Still in Published");
        }

        public void AdminApprove()
        {
            Console.WriteLine("AdminApprove(): Still in Published");
        }

        public void AdminReject()
        {
            Console.WriteLine("AdminReject(): Still in Published");
        }

        public void Expire()
        {
            document.State = document.DraftState;
            Console.WriteLine("Expire(): Published => Draft");
        }

        public override string ToString()
        {
            return "Document state: PUBLISHED";
        }
    }
}
