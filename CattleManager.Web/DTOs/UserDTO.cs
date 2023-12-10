using System.ComponentModel.DataAnnotations;

namespace CattleManager.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    [Required]
    public string Name { get; private set; }
}
