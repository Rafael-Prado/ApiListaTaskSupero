

using ListaTask.Shared.Commads;
using ListTask.Domain.Commands.Inputs;
using ListTask.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ListaTask.Api.Service
{
    public interface ITaskServece
    {
        IEnumerable<Task> GetAll();
        ICommandResult save(CommandsTasks commands);
        Task GetTaskId(Guid id);
    }
}
