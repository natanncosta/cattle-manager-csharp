namespace CattleManager.Domain.Models;

public class User : BaseEntity
{
    public string Name { get; private set; }

    public User(string name)
    {
        ValidParams(name);
        Name = name;
    }

    public void ValidParams(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("invalid name");
    }
}

