namespace CattleManager.Domain.Models;

public class Cattle : BaseEntity
{
    public string Name { get; private set; }
    public string Earring { get; private set; }
    public Gender Gender { get; private set; }
    public int TerrainId { get; private set; }
    public int UserId { get; private set; }

    public Cattle(string name, string earring, int terrainId, int userId, Gender gender)
    {
        Name = name;
        Earring = earring;
        TerrainId = terrainId;
        UserId = userId;
        Gender = gender;
    }
}
