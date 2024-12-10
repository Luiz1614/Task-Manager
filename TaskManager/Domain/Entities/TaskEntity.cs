using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Domain.Entities;

[Table("Tasks")]
public class Task : BaseEntity
{
    private string Title { get; set; }
    private string Description { get; set; }
    private DateTime DueDate { get; set; }
    private bool IsComplete { get; set; }
    private User User { get; set; }
}
