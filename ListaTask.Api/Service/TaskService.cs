using System;
using System.Collections.Generic;
using ListaTask.Shared.Commads;
using ListTask.Domain.Commands.Handlers;
using ListTask.Domain.Commands.Inputs;
using ListTask.Domain.Commands.Outputs;
using ListTask.Domain.Entities;
using ListTask.Domain.Repository.Interface;

namespace ListaTask.Api.Service
{
    public class TaskService : ITaskServece
    {
        private readonly ITaskInterfaceRepository _taskInterfaceRepository;
        private readonly TaskCommandHandler _handler;

        public TaskService(ITaskInterfaceRepository taskInterfaceRepository, TaskCommandHandler handler)
        {
            _taskInterfaceRepository = taskInterfaceRepository;
            _handler = handler;
        }

        public IEnumerable<Task> GetAll()
        {
            var tasks = _taskInterfaceRepository.GetTask();
            return tasks;
        }

        public Task GetTaskId(Guid id)
        {
            var task = _taskInterfaceRepository.GetTaskId(id);
            return task;
        }

        public ICommandResult save(CommandsTasks commands)
        {
           var result = _handler.Handle(commands);
            return result;
        }
    }
}