namespace State.RefactoringGuru
{
    public class Document
    {
        public IState DraftState { get; set; }
        public IState ModerationState { get; set; }
        public IState PublishedState { get; set; }

        public IState State { get; set; }

        public Document()
        {
            DraftState = new DraftState(this);
            ModerationState = new ModerationState(this);
            PublishedState = new PublishedState(this);

            State = DraftState;
        }

        public void PublishedByUser()
        {
            State.UserPublish();
        }

        public void PublishedByAdmin()
        {
            State.AdminPubish();
        }

        public void ApprovedByAdmin()
        {
            State.AdminApprove();
        }

        public void RejectedByAdmin()
        {
            State.AdminReject();
        }

        public void BackToDraft()
        {
            State.Expire();
        }
    }
}
