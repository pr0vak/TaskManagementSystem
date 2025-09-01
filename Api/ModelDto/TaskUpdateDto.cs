using System.ComponentModel.DataAnnotations;

namespace TaskManagement.API.ModelDto;

public class TaskUpdateDto
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public Models.TaskStatus Status { get; set; }
}
