namespace CattleManager.Domain.Models;

public class Cattle : BaseEntity
{
    public string Name { get; set; }
    public string Earring { get; set; }
    public Gender Gender { get; set; }
    public int TerrainId { get; set; }
    public int UserId { get; set; }

    public Cattle(
        string name,
        string earring,
        int terrainId,
        int userId,
        Gender gender)
    {
        Name = name;
        Earring = earring;
        TerrainId = terrainId;
        UserId = userId;
        Gender = gender;
    }
}
