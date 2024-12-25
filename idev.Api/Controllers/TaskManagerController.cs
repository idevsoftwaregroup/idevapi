using idev.Application.Interface;
using idev.Domain.Models.Requests;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class TaskManagerController : ControllerBase
{
    private readonly ITaskManagerService _service;

    public TaskManagerController(ITaskManagerService service)
    {
        _service = service;
    }

    [HttpPost("CreateTaskManager")]
    public async Task<ActionResult<object>> CreateTask([FromBody] CreateTask create)
    {
        if (create == null)
        {
            return BadRequest($"اطلاعات مربوط به ایجاد تسک جدید نباید خالی باشد.");
        }
        try
        {
            var result = await _service.CreateTaskAsync(create);
            return result;
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
