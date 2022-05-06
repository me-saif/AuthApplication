namespace AuthApplication.IRepository
{
    public interface IUserService
    {
        string GetUserId();

        bool IsAuthenticated();
    }
}