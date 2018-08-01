using ListTask.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ListTask.Domain.Repository.Interface
{
    public interface ITaskInterfaceRepository
    {
        void Save(Task task);
        IEnumerable<Task> GetTask();
        Task GetTaskId(Guid id);
    }
}
