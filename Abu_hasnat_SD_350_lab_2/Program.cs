public abstract class Client
{
    public string UserName {  get; set; }
    public string Email { get; set; }
    public string Description { get; set; } = "No Description";
    public virtual string GetDescription()
    {
        return Description;
    }
}

public class User: Client
{
    public User(string username, string email)
    {
        username = username;
        Email = email;
        Description = "Base-level User";
    }
}

public abstract class BadgeDecorator: Client
{
    public Client Cleint { get; set }
    public abstract override string GetBadges(); //
}