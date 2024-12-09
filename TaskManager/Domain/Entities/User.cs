using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Domain.Entities;

[Table("Users")]
public class User : BaseEntity
{
    private string Name { get; set; }
    private string Email { get; set; }

    List<Task> Tasks{ get; set; }
}
