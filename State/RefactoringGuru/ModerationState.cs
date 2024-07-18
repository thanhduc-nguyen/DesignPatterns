namespace State.RefactoringGuru
{
    public class ModerationState(Document document) : IState
    {
        public void UserPublish()
        {
            Console.WriteLine("UserPublish(): Still in Moderation");
        }

        public void AdminPubish()
        {
            Console.WriteLine("AdminPubish(): Still in Moderation");
        }

        public void AdminApprove()
        {
            document.State = document.PublishedState;
            Console.WriteLine("AdminApprove(): Moderation => Published");
        }

        public void AdminReject()
        {
            document.State = document.DraftState;
            Console.WriteLine("AdminReject(): Moderation => Draft");
        }

        public void Expire()
        {
            Console.WriteLine("Expire(): Still in Moderation");
        }

        public override string ToString()
        {
            return "Document state: MODERATION";
        }
    }
}
