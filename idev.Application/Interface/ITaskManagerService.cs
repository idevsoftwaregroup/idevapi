using idev.Domain.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idev.Application.Interface
{
    public interface ITaskManagerService
    {
        Task<object> CreateTaskAsync(CreateTask create);
    }
}
