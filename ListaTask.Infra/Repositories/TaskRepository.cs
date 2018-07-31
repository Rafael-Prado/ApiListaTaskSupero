using ListaTask.Infra.Context;
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

        public TaskRepository(ContextListaTask context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetTask()
        {
            return null;
        }

        public Task GetTask(Guid id)
        {
            return _context
                .Task
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }

        public void Save(Task task)
        {
            _context.Task.Add(task);
        }
    }
}
