using Microsoft.AspNetCore.Mvc;
using TaskApi.Application.Services;
using TaskApi.Domain.Entities;

namespace TaskApi.Presentation.Controllers;

[ApiController]
[Route("api/tasks")]
public class TaskController : ControllerBase
{
    private readonly TaskService _taskService;

    public TaskController(TaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public ActionResult<List<TaskItem>> GetAll()
    {
        var tasks = _taskService.GetTasks();
        return Ok(tasks);
    }

    [HttpPost]
    public IActionResult Add([FromBody] TaskItem task)
    {
        if (string.IsNullOrWhiteSpace(task.Title))
        {
            return BadRequest("Title is required.");
        }

        _taskService.AddTask(task);
        return Created($"/api/tasks/{task.Id}", task);
    }
}
