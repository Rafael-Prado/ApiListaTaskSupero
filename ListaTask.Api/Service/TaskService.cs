using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListTask.Domain.Entities;
using ListTask.Domain.Repository.Interface;

namespace ListaTask.Api.Service
{
    public class TaskService : ITaskServece
    {
        private readonly ITaskInterfaceRepository _taskInterfaceRepository;

        public TaskService(ITaskInterfaceRepository taskInterfaceRepository)
        {
            _taskInterfaceRepository = taskInterfaceRepository;
        }

        public void save(Task task)
        {
            _taskInterfaceRepository.Save(task);
        }
    }
}