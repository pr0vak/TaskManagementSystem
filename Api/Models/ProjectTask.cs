using System.ComponentModel.DataAnnotations;

namespace TaskManagement.API.Models;

public class ProjectTask
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public TaskStatus Status { get; set; }
}
