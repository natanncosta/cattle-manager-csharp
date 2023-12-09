namespace CattleManager.Domain.Models;

public class Terrain : BaseEntity
{
    public string Description { get; private set; }

    public Terrain(string description)
    {
        ValidParams(description);
        Description = description;
    }

    private void ValidParams(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new InvalidOperationException("Description is invalid");
    }
}

