using idev.Domain.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idev.Infrastructure.Interface
{
    public interface ITaskManagerRepository
    {
        public Task<object> CreateTaskAsync(CreateTask create);
    }
}
