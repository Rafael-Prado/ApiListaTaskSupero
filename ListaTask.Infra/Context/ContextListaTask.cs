
using ListaTask.Infra.Mappings;
using ListaTask.Shared;
using ListTask.Domain.Entities;
using System.Data.Entity;

namespace ListaTask.Infra.Context
{
    public class ContextListaTask: DbContext
    {
        public ContextListaTask() : base(Settings.ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Task> Task { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}
