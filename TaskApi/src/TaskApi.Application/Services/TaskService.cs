using TaskApi.Domain.Entities;
using TaskApi.Domain.Repositories;

namespace TaskApi.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public List<TaskItem> GetTasks()
    {
        return _taskRepository.GetAll();
    }

    public void AddTask(TaskItem task)
    {
        _taskRepository.Add(task);
    }
}
