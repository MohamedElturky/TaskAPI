using TaskApi.Domain.Entities;

namespace TaskApi.Domain.Repositories;

public interface ITaskRepository
{
    List<TaskItem> GetAll();
    void Add(TaskItem task);
}
