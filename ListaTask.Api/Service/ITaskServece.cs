

using ListaTask.Shared.Commads;
using ListTask.Domain.Commands.Inputs;
using ListTask.Domain.Commands.Outputs;
using ListTask.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ListaTask.Api.Service
{
    public interface ITaskServece
    {
         IEnumerable<TaskCommandResult> GetAll();
        ICommandResult save(CommandsTasks commands);
        IEnumerable<TaskCommandResult> GetTaskSituacao(int situacao);
        Task GetTaskId(Guid id);
    }
}
