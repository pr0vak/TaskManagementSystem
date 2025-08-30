using System.ComponentModel.DataAnnotations;

namespace TaskManagement.API.Models;

public class TaskCreateDto
{
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public TaskStatus Status { get; set; }
}
