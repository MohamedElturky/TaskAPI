using TaskApi.Domain.Entities;
using TaskApi.Domain.Repositories;

namespace TaskApi.Infrastructure.Repositories;

public class FakeTaskRepository : ITaskRepository
{
    private readonly List<TaskItem> _tasks = new()
    {
        new TaskItem { Id = 1, Title = "Learn Clean Architecture basics" }
    };

    public List<TaskItem> GetAll()
    {
        return _tasks;
    }

    public void Add(TaskItem task)
    {
        if (task.Id <= 0)
        {
            task.Id = _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;
        }

        _tasks.Add(task);
    }
}
