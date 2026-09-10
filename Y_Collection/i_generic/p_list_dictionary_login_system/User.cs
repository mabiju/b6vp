#nullable disable
public class User
{
    private string username;
    private string password;
    private string firstName;
    private string lastName;

    public string Username
    {
        get
        {
            return username;
        }
        set
        {
            username = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
        }
    }
}