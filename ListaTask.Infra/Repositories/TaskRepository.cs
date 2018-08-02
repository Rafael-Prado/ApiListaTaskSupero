using ListaTask.Infra.Context;
using ListaTask.Infra.Data;
using ListTask.Domain.Entities;
using ListTask.Domain.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaTask.Infra.Repositories
{
    public class TaskRepository : ITaskInterfaceRepository
    {
        private readonly ContextListaTask _context;
        private readonly ListaTaskContext _taskContext;

        public TaskRepository(ContextListaTask context, ListaTaskContext taskContext)
        {
            _context = context;
            _taskContext = taskContext;
        }

        public IEnumerable<Task> GetTask()
        {
            _taskContext.BeginTransaction();
            return _context.Task
                .AsNoTracking()
                .OrderBy(x => x.DataCreate);

        }

        public Task GetTaskId(Guid id)
        {
            _taskContext.BeginTransaction();

            return _context
                .Task
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

            _taskContext.Dispose();
        }

        public void Save(Task task)
        {
            if (task != null)
            {
                _context.Task.Add(task);
            }           

        }
    }
}
