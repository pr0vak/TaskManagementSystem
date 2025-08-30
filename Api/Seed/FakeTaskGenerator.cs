using Bogus;
using TaskManagement.API.Models;
using TaskStatus = TaskManagement.API.Models.TaskStatus;

namespace TaskManagement.API.Seed;

public static class FakeTaskGenerator
{
    public static List<ProjectTask> GenerateProjectTaskList(int count = 50)
    {
        var statuses = Enum.GetValues(typeof(TaskStatus)).Cast<TaskStatus>().ToList();
        return new Faker<ProjectTask>("ru")
            .RuleFor(t => t.Id, f => f.IndexFaker + 1)
            .RuleFor(t => t.Title, f => f.Hacker.Phrase())
            .RuleFor(t => t.Description, f => f.Lorem.Sentence(3, 2))
            .RuleFor(t => t.Status, f => f.PickRandom(statuses))
            .Generate(count);
    }
}
