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
            return null;
        }

        public Task GetTask(Guid id)
        {
            _taskContext.BeginTransaction();

            return _context
                .Task
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }

        public void Save(Task task)
        {
            if (task != null)
            {
                _taskContext.BeginTransaction();

                _context.Task.Add(task);

                _taskContext.Commit();
            }           

            _taskContext.Dispose();
        }
    }
}
