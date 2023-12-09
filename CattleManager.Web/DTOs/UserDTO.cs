using System.ComponentModel.DataAnnotations;

namespace CattleManager.Web.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    [Required]
    public string Name { get; private set; }
}
