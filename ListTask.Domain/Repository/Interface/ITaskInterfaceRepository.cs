
using ListTask.Domain.Commands.Outputs;
using ListTask.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ListTask.Domain.Repository.Interface
{
    public interface ITaskInterfaceRepository
    {
        void Save(Task task);
        IEnumerable<TaskCommandResult> GetTask();
        IEnumerable<TaskCommandResult> GetTaskSituacao(int situacao);
        Task GetTaskId(Guid id);
    }
}
