namespace State.RefactoringGuru
{
    public class DraftState(Document document) : IState
    {
        public void UserPublish()
        {
            document.State = document.ModerationState;
            Console.WriteLine("UserPublish(): Draft => Moderation");
        }

        public void AdminPubish()
        {
            document.State = document.PublishedState;
            Console.WriteLine("AdminPubish(): Draft => Published");
        }

        public void AdminApprove()
        {
            Console.WriteLine("AdminApprove(): Still in Draft");
        }

        public void AdminReject()
        {
            Console.WriteLine("AdminReject(): Still in Draft");
        }

        public void Expire()
        {
            Console.WriteLine("Expire(): Still in Draft");
        }

        public override string ToString()
        {
            return "Document state: DRAFT";
        }
    }
}
