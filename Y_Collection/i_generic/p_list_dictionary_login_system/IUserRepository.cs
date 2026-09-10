public interface IUserRepository
{
    User Login(string username, string password);
}