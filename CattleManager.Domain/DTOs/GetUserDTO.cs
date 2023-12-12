using System.ComponentModel.DataAnnotations;

namespace CattleManager.Domain.DTOs;

public class GetUserDTO
{
    public int Id { get; set; }
    [Required]
    public string Name { get; private set; } = string.Empty;
}
