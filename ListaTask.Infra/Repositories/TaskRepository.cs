using Dapper;
using ListaTask.Infra.Context;
using ListaTask.Shared;
using ListTask.Domain.Commands.Outputs;
using ListTask.Domain.Entities;
using ListTask.Domain.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public IEnumerable<TaskCommandResult> GetTask()
        {
            var query = "SELECT  [Id],[Titulo],[Corpo],[Situacao],[DataCreate],[DataFinalizacao] FROM [supero].[dbo].[Task]";
            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();
                return conn
                    .Query<TaskCommandResult>(query)
                    .OrderBy(x => x.DataCreate);
            }

        }

        public Task GetTaskId(Guid id)
        {
            

            return _context
                .Task
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);

            
        }

        public IEnumerable<TaskCommandResult> GetTaskSituacao(int situacao)
        {
            var query = "SELECT  [Id],[Titulo],[Corpo],[Situacao],[DataCreate],[DataFinalizacao] FROM [supero].[dbo].[Task]";
            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                conn.Open();
                return conn
                    .Query<TaskCommandResult>(query)
                    .Where(x => x.Situacao == situacao.ToString())
                    .OrderBy(x => x.DataCreate);
            }
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
