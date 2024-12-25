using idev.Domain.Models.DTOs;
using idev.Domain.Models.Requests;
using idev.Framework.Operations;
using idev.Infrastructure.Context;
using idev.Infrastructure.Interface;
using Microsoft.Extensions.Logging;
using Status = idev.Domain.Models.DTOs.Status;

namespace idev.Infrastructure.Service
{
    public class TaskManagerRepository : ITaskManagerRepository
    {
        private readonly IdevContext _context;
        private readonly ILogger<TaskManagerRepository> _logger;

        public TaskManagerRepository(IdevContext context, ILogger<TaskManagerRepository> logger = null)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<object> CreateTaskAsync(CreateTask create)
        {
            OperationResult<object> operationResult = new("CreateTaskAsync");

            if (create == null)
            {
                return operationResult.Failed("CreateTask object is null.", create);
            }

            if (string.IsNullOrEmpty(create.TaskName))
            {
                return operationResult.Failed("TaskName is required.", create);
            }

            try
            {
                // Create a new task object
                var newTask = new TaskManager
                {
                    Id = create.Id,
                    TaskName = create.TaskName,
                    TaskDetails = create.TaskDetails,
                    TaskType = create.TaskType,
                    // Add the Status object as part of the TaskManager entity
                    Status = new Status
                    {
                        TaskStatus = true, // Default status, assuming true indicates the task is active
                    }
                };

                // Add and save the task in the database
                _context.Tasks.Add(newTask);
                await _context.SaveChangesAsync(); // Entity Framework will automatically save Status as part of TaskManager

                _logger?.LogInformation($"Task with ID {newTask.Id} created successfully.");

                return create; // Return the input object with updated details
            }
            catch (Exception ex)
            {
                // Log the exception details
                _logger?.LogError(ex, "An error occurred while creating the task.");

                return operationResult.Failed($"An error occurred: {ex.Message}", create);
            }
        }
    }
}
