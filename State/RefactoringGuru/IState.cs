namespace State.RefactoringGuru
{
    public interface IState
    {
        public void UserPublish();
        public void AdminPubish();
        public void AdminApprove();
        public void AdminReject();
        public void Expire();
    }
}
