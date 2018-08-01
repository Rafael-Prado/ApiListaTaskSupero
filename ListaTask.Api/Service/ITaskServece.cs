

using ListTask.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ListaTask.Api.Service
{
    public interface ITaskServece
    {
        IEnumerable<Task> GetAll();
        void save(Task task);
        Task GetTaskId(Guid id);
    }
}
