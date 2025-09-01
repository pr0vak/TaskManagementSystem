using System.ComponentModel.DataAnnotations;

namespace TaskManagement.API.ModelDto;

public class TaskCreateDto
{
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public Models.TaskStatus Status { get; set; }
}
