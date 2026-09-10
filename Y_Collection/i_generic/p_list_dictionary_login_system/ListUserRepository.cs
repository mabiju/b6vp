#nullable disable
public class ListUserRepository : IUserRepository
{
    List<User> userList = new List<User>();

    public ListUserRepository()
    {
        userList.Add(new User
        {
            FirstName = "Ram",
            LastName = "Shrestha",
            Username = "ram",
            Password = "ram@123"
        });

        userList.Add(new User
        {
            FirstName = "Shyam",
            LastName = "Thapa",
            Username = "shyam",
            Password = "shyam@123"
        });

        userList.Add(new User
        {
            FirstName = "Hari",
            LastName = "Thapa",
            Username = "hari",
            Password = "hari@123"
        });
    }

    public User Login(string username, string password)
    {
        foreach (User listedUser in userList)
        {
           if (listedUser.Username == username && listedUser.Password == password)
           {
               return listedUser;
           }
        }
        return null;
    }
}