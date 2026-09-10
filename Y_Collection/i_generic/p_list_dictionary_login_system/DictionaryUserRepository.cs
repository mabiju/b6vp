#nullable disable
public class DictionaryUserRepository : IUserRepository
{
    Dictionary<string, User> users = new Dictionary<string, User>();
    public DictionaryUserRepository()
    {
        users.Add("ram", new User
        {
            FirstName = "Ram",
            LastName = "Thapa",
            Username = "ram",
            Password = "ram@123"
        });

        users.Add("shyam", new User
        {
            FirstName = "Shyam",
            LastName = "Thapa",
            Username = "shyam",
            Password = "shyam@123"
        });

        users.Add("hari", new User
        {
            FirstName = "Hari",
            LastName = "Thapa",
            Username = "hari",
            Password = "hari@123"
        });
    }

    public User Login(string username, string password)
    {
        if (users.ContainsKey(username) && users[username].Password == password)
        {
            return users[username];
        }
        else
        {
            return null;
        }
    }
}