namespace CattleManager.Domain.Models;

public class User : BaseEntity
{
    public string Name { get; set; }

    public User(string name)
    {
        ValidParams(name);
        Name = name;
    }

    public User(int id, string name)
    {
        ValidParams(name);
        Id = id;
        Name = name;
    }

    public void ValidParams(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("invalid name");
    }
}

