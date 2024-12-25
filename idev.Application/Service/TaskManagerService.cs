using idev.Application.Interface;
using idev.Domain.Models.Requests;
using idev.Infrastructure.Interface;

public class TaskManagerService : ITaskManagerService
{
    private readonly ITaskManagerRepository _repository;

    public TaskManagerService(ITaskManagerRepository repository)
    {
        _repository = repository;
    }

    public async Task<object> CreateTaskAsync(CreateTask create)
    {
        var result = await _repository.CreateTaskAsync(create);
        return result;
    }
}
